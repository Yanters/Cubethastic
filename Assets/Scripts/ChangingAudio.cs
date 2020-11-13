using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingAudio : MonoBehaviour
{
    public static void AudioChange()
    {

        if (AudioManager.MenuMusicBool)
        {
            AudioManager.LevelMusicBool = false;
            AudioManager.LevelMusicWasPlaying = false;

            FindObjectOfType<AudioManager>().StopPlay("LevelMusic");
            FindObjectOfType<AudioManager>().Play("MenuMusic");

            AudioManager.MenuMusicBool = true;
            AudioManager.MenuMusicWasPlaying = true;
        }
        else if (AudioManager.LevelMusicBool)
        {
            AudioManager.MenuMusicBool = false;
            AudioManager.MenuMusicWasPlaying = false;

            FindObjectOfType<AudioManager>().StopPlay("MenuMusic");
            FindObjectOfType<AudioManager>().Play("LevelMusic");

            AudioManager.LevelMusicBool = true;
            AudioManager.LevelMusicWasPlaying = true;
        }

    }
}
