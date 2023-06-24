using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BrickGeneratorScript : MonoBehaviour
{
    public GameObject brick;
    public Vector2 offset;
    static public int nBrick = 0;
    public Vector2Int size;
    public BallScript BallScript { get; set; }

    void Awake()
    {
        for(int i=0; i<size.x; i++)
        {
            for(int j=0; j<size.y; j++)
            {
                GameObject newBrick = Instantiate(brick, transform);
                newBrick.transform.position = transform.position + new Vector3((((float)(size.x-1)*0.5f-i)* offset.x), j*offset.y, 0);
                nBrick++;
                BrickScript brickScript = newBrick.GetComponent<BrickScript>();
                brickScript.BrickGeneratorScript = this;

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       Debug.Log("Numero brick= " + nBrick);
    }

    // Update is called once per frame
    void Update()
    {
        if (BallScript.ballsLeft <= 0 && nBrick > 0)
        {
            SceneManager.LoadScene(2);
        }else if(nBrick <= 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
