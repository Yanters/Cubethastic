using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IsButtonAvalible : MonoBehaviour
{
    //public Cheats CH;
   
    public void Avalible()
    {
        //PlayerPrefs.GetInt("lvl" + transform.GetComponentInChildren<Text>().text.ToLower()) == 1 || 
       
        if (PlayerPrefs.GetInt("lvl" + transform.GetComponentInChildren<Text>().text.ToLower()) == 1 || Cheats.IsOn==true)
        {
           
            
            transform.GetComponentInChildren<Shadow>().effectColor = new Color32(161, 161, 161, 255);
           
        }
        else
        {
            
            transform.GetComponentInChildren<Shadow>().effectColor = new Color32(255, 0, 0, 200);
            
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        Avalible();
    }

    // Update is called once per frame
    void Update()
    {
        //Avalible();   
    }
}
