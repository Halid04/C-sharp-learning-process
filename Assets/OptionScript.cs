using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class OptionScript : MonoBehaviour
{
    public void option()
    {
        string clickedBtnName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(clickedBtnName);
        if (clickedBtnName.Equals("Replay Button"))
        {
            SceneManager.LoadScene(0);
            BrickGeneratorScript.nBrick = 0;
            BallScript.ballsLeft = 4;
        }
        else if (clickedBtnName.Equals("Quit Button"))
        {
            Debug.Log("Player quit");
            Application.Quit();
        }
    }
}
