using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Swich to scene "Menu"
    private void Start()
    {
        ChangingAudio.AudioChange();

    }
    public void BackingToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
