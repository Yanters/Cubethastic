using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    private void Start()
    {
        AudioManager.MenuMusicBool = true;
        if (AudioManager.MenuMusicWasPlaying != AudioManager.MenuMusicBool)
        {
            ChangingAudio.AudioChange();
            AudioManager.MenuMusicWasPlaying = true;
        }
    }
    public void StartGame()
    {

        // Loading top-level 
        if (PlayerPrefs.GetInt("TopLevel") >= 1)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("TopLevel"));
        }
        else
        {
            SceneManager.LoadScene(1);
        }


    }
}
