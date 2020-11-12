using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IsButtonAvalible : MonoBehaviour
{
       
    public void Avalible()
    {
        //Putting shadows on the buttons 'Level x' Grey - ON, Red = OFF

        if (PlayerPrefs.GetInt("lvl" + transform.GetComponentInChildren<Text>().text.ToLower()) == 1 || Cheats.IsOn==true)
        {
           
            
            transform.GetComponentInChildren<Shadow>().effectColor = new Color32(161, 161, 161, 255);
           
        }
        else
        {
            
            transform.GetComponentInChildren<Shadow>().effectColor = new Color32(255, 0, 0, 200);
            
        }

    }
    // When Buttons appear It checks if they are avalible
    void Start()
    {
        Avalible();
    }

}
