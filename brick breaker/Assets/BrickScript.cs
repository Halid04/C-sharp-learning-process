using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    public bool brickTouched = false;
    public BrickGeneratorScript BrickGeneratorScript { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (brickTouched)
        {
            Destroy(gameObject);
            BrickGeneratorScript.nBrick--;
            Debug.Log(BrickGeneratorScript.nBrick);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Brick touched");
        brickTouched = true;
    }
}
