using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{


    public void Start()
    {
        PlayerPrefs.SetInt("lvllevel 1", 1);

    }

    public void PickLevel()
    {



        if (transform.GetComponentInChildren<Text>().text.Contains("LEVEL "))
        {
            if (PlayerPrefs.GetInt("lvl" + transform.GetComponentInChildren<Text>().text.ToLower()) == 1||Cheats.IsOn)
            {
               // transform.GetComponentInChildren<Button>().enabled = false;
                //Debug.Log("NAME OF PREFAB LEVEL COMPLETE: lvl" + transform.GetComponentInChildren<Text>().text);
                
                SceneManager.LoadScene(transform.GetComponentInChildren<Text>().text);
                Debug.Log("LOADING LEVEL");
            }
        }
        else
        {
            Debug.Log("LOADING LEVEL");
            SceneManager.LoadScene(transform.GetComponentInChildren<Text>().text);
        }
        
    }
}
