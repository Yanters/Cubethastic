using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingAudio : MonoBehaviour
{
    public static void AudioChange()
    {

        if (SceneManager.GetActiveScene().name.Contains("Level ") && !AudioManager.LevelMusicWasPlaying)
        {
            AudioManager.LevelMusicWasPlaying = true;
            AudioManager.MenuMusicWasPlaying = false;
            FindObjectOfType<AudioManager>().StopPlay("MenuMusic");
            FindObjectOfType<AudioManager>().Play("LevelMusic");
        }
        if (!SceneManager.GetActiveScene().name.Contains("Level ") && !AudioManager.MenuMusicWasPlaying)
        {
            AudioManager.MenuMusicWasPlaying = true;
            AudioManager.LevelMusicWasPlaying = false;
            FindObjectOfType<AudioManager>().StopPlay("LevelMusic");
            FindObjectOfType<AudioManager>().Play("MenuMusic");
        }

        //if (AudioManager.MenuMusicBool && !AudioManager.MenuMusicWasPlaying)
        //{
        //    Debug.LogWarning("ODPALAM MUZYKE OD MENU");
        //    AudioManager.LevelMusicWasPlaying = false;

        //    FindObjectOfType<AudioManager>().StopPlay("LevelMusic");
        //    FindObjectOfType<AudioManager>().Play("MenuMusic");

        //    AudioManager.MenuMusicWasPlaying = true;
        //}
        //else if (AudioManager.LevelMusicBool && !AudioManager.LevelMusicWasPlaying)
        //{
        //    Debug.LogWarning("ODPALAM MUZYKE OD LEVELU");
        //    AudioManager.MenuMusicWasPlaying = false;

        //    FindObjectOfType<AudioManager>().StopPlay("MenuMusic");
        //    FindObjectOfType<AudioManager>().Play("LevelMusic");

        //    AudioManager.LevelMusicWasPlaying = true;
        //}

    }
}
