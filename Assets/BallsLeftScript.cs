using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsLeftScript : MonoBehaviour
{
    public BallScript BallScript { get; set; }
    public GameObject firstBall;
    public GameObject secondBall;
    public GameObject thirdBall;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        switch (BallScript.ballsLeft)
        {
            case 1:
                Destroy(firstBall);
                break;

            case 2:
                Destroy(secondBall);
                break;

            case 3:
                Destroy(thirdBall);
                break;
        }
    }
}
