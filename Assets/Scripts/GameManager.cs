using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float RestartDelay = 1.0f;
    public IsButtonAvalible iba;
    int SaveAttempt;
    float HSSaveAttempt;
    public Score sc;
    public GameObject CompleteLevelUI;
    public GameObject AC;
    public string prefsname;
    public string HSprefsname;
    public string lvlcomplete;

    void Start()
    {

        prefsname = SceneManager.GetActiveScene().name;
        lvlcomplete = "lvl" + SceneManager.GetActiveScene().name.ToLower();
        PlayerPrefs.GetInt(lvlcomplete);
        //Checking if Level is complete
        if (!Cheats.IsOn)
        {
            PlayerPrefs.SetInt(lvlcomplete, 1);
        }
        //Saving number of scene of top-level
        if (!Cheats.IsOn)
        {
            if (PlayerPrefs.GetInt("TopLevel") < SceneManager.GetActiveScene().buildIndex)
                PlayerPrefs.SetInt("TopLevel", SceneManager.GetActiveScene().buildIndex);
        }
        int SaveAttempt = PlayerPrefs.GetInt(prefsname);
        if (SaveAttempt == 0)
        {
            SaveAttempt = 1;
            PlayerPrefs.SetInt(prefsname, SaveAttempt);
        }

        HSprefsname = "HS" + SceneManager.GetActiveScene().name;

        float HSSaveAttempt = PlayerPrefs.GetFloat(HSprefsname);

        AudioManager.MenuMusicBool = false;
        AudioManager.LevelMusicBool = true;
        ChangingAudio.AudioChange();



    }


    //Reseting Attempts in specific level
    public void AttemptReset()
    {
        PlayerPrefs.SetInt(prefsname, 1);
        SaveAttempt = PlayerPrefs.GetInt(prefsname);

    }

    //Updating Attempts in specific level
    public void AttemptUpdate()
    {
        SaveAttempt = PlayerPrefs.GetInt(prefsname) + 1;
        PlayerPrefs.SetInt(prefsname, SaveAttempt);


    }

    //Updating HighScore in specific level
    public void HighScoreUpdate()
    {
        if (sc.scoreProcentage > PlayerPrefs.GetFloat(HSprefsname))
        {
            HSSaveAttempt = Mathf.Round(sc.scoreProcentage);
        }
        else
        {
            HSSaveAttempt = PlayerPrefs.GetFloat(HSprefsname);
        }
        PlayerPrefs.SetFloat(HSprefsname, HSSaveAttempt);
    }

    //Restarting Level using function RestartGame()
    public void GameOver()
    {

        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", RestartDelay);


        }
    }
    // Restarting Level 
    void RestartGame()
    {
        AttemptUpdate();
        HighScoreUpdate();
        Debug.Log("RESTART");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    // After finishing level move to next one
    public void CompleteLevel()
    {


        PlayerPrefs.SetFloat(HSprefsname, 100);
        Debug.Log("LEVEL COMPLETE WINDOW");
        iba.Avalible();
        CompleteLevelUI.SetActive(true);



    }

}
