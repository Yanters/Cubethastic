using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
        
    
    public void PickLevel()
    {



        if (transform.GetComponentInChildren<Text>().text.Contains("LEVEL "))
        {
            if (PlayerPrefs.GetInt("lvl" + transform.GetComponentInChildren<Text>().text.ToLower()) == 1)
            {
                transform.GetComponentInChildren<Button>().enabled = false;
                //Debug.Log("NAME OF PREFAB LEVEL COMPLETE: lvl" + transform.GetComponentInChildren<Text>().text);
                Debug.Log(transform.GetComponentInChildren<Text>().text);
        Debug.Log(transform.GetComponentInChildren<Text>().text);
        Debug.Log(transform.GetComponentInChildren<Text>().text);
        Debug.Log(transform.GetComponentInChildren<Text>().text);
        SceneManager.LoadScene(transform.GetComponentInChildren<Text>().text);
        Debug.Log("LOADING LEVEL");
            }else
            { transform.GetComponentInChildren<Button>().enabled = true ; }
        }
        else
        {
            Debug.Log("LOADING LEVEL");
            SceneManager.LoadScene(transform.GetComponentInChildren<Text>().text);
        }
        
    }
}
