using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveToSceneOfText : MonoBehaviour
{
   
    // Start is called before the first frame update
   public void ToScene()
    {
        SceneManager.LoadScene(transform.GetComponentInChildren<Text>().text);
       
    }
}
