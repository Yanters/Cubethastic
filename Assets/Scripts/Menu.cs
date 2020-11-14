﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    private void Start()
    {
        if (!AudioManager.MenuMusicBool)
        {
            AudioManager.LevelMusicBool = false;
            AudioManager.MenuMusicBool = true;
            ChangingAudio.AudioChange();
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
