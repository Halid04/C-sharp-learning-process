using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketScript : MonoBehaviour
{
    public float mooveSpeed = 5;
    static public bool mouseControllOn = true;
    static public bool keyboardControllOn = false;

    private Camera mainCamera;
    private Vector2 screenBounds;
    private float objectWidth;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, mainCamera.transform.position.z));
        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 clampedPosition = transform.position;
        if (keyboardControllOn && !mouseControllOn)
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
            {
                clampedPosition.x = Mathf.Clamp(transform.position.x + (mooveSpeed * Time.deltaTime), screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
            }
            else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
            {
                clampedPosition.x = Mathf.Clamp(transform.position.x - (mooveSpeed * Time.deltaTime), screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
            }
        }
        else if (mouseControllOn)
        {
            Vector3 mousePosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            clampedPosition.x = Mathf.Clamp(mousePosition.x, screenBounds.x * -1 + objectWidth, screenBounds.x - objectWidth);
            
        }
        transform.position = clampedPosition;

       
    }
}
