using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseLevel : MonoBehaviour
{
    //public Button ButtonText;
    public void PickLevel()
    {
        SceneManager.LoadScene(transform.GetComponentInChildren<Text>().text);
    }
}
