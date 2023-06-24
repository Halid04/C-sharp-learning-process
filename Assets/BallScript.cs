using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 500f;
    private Rigidbody2D rigidBody { get; set;}
    public float deadzone = -6.5f;
    static public int ballsLeft = 4;

    void Start()
    {   
        rigidBody = GetComponent<Rigidbody2D>();
        Invoke(nameof(setRandomTrajectory), 2f);

        
    }

    void Update()
    {
        if (transform.position.y < deadzone)
        {
            Debug.Log("palla distrutta");
            destroyBall();
        }
    }

    public void setRandomTrajectory()
    {
        rigidBody.AddForce(new Vector2(0.3f, -1).normalized * speed);
    }

    public void destroyBall()
    {
        Destroy(gameObject);
        ballsLeft--;
    }
}
