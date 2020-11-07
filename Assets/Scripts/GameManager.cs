using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;

    public float RestartDelay = 1.0f;


    int SaveAttempt;

    public GameObject CompleteLevelUI;
    public GameObject AC;
    public string prefsname;

    void Start()
    {
        prefsname = SceneManager.GetActiveScene().name;
        
        int SaveAttempt = PlayerPrefs.GetInt(prefsname);
    }


    public void AttemptReset()
    {
        PlayerPrefs.SetInt(prefsname, 1);
        SaveAttempt = PlayerPrefs.GetInt(prefsname);
    }
    public void AttemptUpdate()
    {
        SaveAttempt = PlayerPrefs.GetInt(prefsname) + 1;
        PlayerPrefs.SetInt(prefsname, SaveAttempt);
    }

    public void GameOver()
    {
        
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", RestartDelay);
            
            
        }
    }

    void RestartGame()
    {
        AttemptUpdate();
        Debug.Log("RESTART");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {

        //AttemptReset();
        
        Debug.Log("LEVEL COMPLETE WINDOW");
        CompleteLevelUI.SetActive(true);
        
        Debug.Log("LEVEL COMPLETEeeeeeeeeeeeeeeeeeeeeeeeeee WINDOW");
        
    }

}
