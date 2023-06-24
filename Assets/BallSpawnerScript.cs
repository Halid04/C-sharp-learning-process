using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawnerScript : MonoBehaviour
{
    public GameObject ball;
    public BallScript BallScript { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Ball(Clone)") == null && BallScript.ballsLeft > 0)
        {
            Debug.Log("nuova palla creata");
            generateBall();
        }
    }

    public void generateBall()
    {
        Instantiate(ball, new Vector3(0, -3.5f, 0), transform.rotation);
    }
}
