using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Swich to scene "Menu"
    private void Start()
    {

        AudioManager.MenuMusicBool = true;
        if (AudioManager.MenuMusicWasPlaying != AudioManager.MenuMusicBool)
        {
            ChangingAudio.AudioChange();
            AudioManager.MenuMusicWasPlaying = true;
        }
    }
    public void BackingToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
