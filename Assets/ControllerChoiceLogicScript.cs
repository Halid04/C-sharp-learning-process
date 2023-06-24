using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ControllerChoiceLogicScript : MonoBehaviour
{
    public void getBtnName()
    {
        string clickedBtnName = EventSystem.current.currentSelectedGameObject.name;
        Debug.Log(clickedBtnName);
        if (clickedBtnName.Equals("Keyboard"))
        {
            RacketScript.keyboardControllOn = true;
            RacketScript.mouseControllOn = false;
        }
        else if (clickedBtnName.Equals("Mouse"))
        {
            RacketScript.mouseControllOn = true;
            RacketScript.keyboardControllOn = false;
        }
        SceneManager.LoadScene(1);
    }
}
