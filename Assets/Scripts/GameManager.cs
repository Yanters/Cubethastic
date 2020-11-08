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
    float HSSaveAttempt;
    public Score sc;
    public GameObject CompleteLevelUI;
    public GameObject AC;
    public string prefsname;
    public string HSprefsname;
    void Start()
    {
        prefsname = SceneManager.GetActiveScene().name;
        
        int SaveAttempt = PlayerPrefs.GetInt(prefsname);

        HSprefsname = "HS" + SceneManager.GetActiveScene().name;

        float HSSaveAttempt = PlayerPrefs.GetFloat(HSprefsname);
        
    }
    void Update()
    {
        //Debug.Log("Procenty: "+sc.scoreProcentage.ToString());
       
    }
    public void AttemptReset()
    {
        PlayerPrefs.SetInt(prefsname, 1);
        SaveAttempt = PlayerPrefs.GetInt(prefsname);

        PlayerPrefs.SetFloat(HSprefsname, 0);
        HSSaveAttempt = PlayerPrefs.GetFloat(HSprefsname);
    }
    public void AttemptUpdate()
    {
        SaveAttempt = PlayerPrefs.GetInt(prefsname) + 1;
        PlayerPrefs.SetInt(prefsname, SaveAttempt);

        
    }
    public void HighScoreUpdate()
    {
        if(sc.scoreProcentage> PlayerPrefs.GetFloat(HSprefsname))
        {
            HSSaveAttempt = Mathf.Round(sc.scoreProcentage); 
        }else
        {
            HSSaveAttempt = PlayerPrefs.GetFloat(HSprefsname);
        }
        PlayerPrefs.SetFloat(HSprefsname, HSSaveAttempt);
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
        HighScoreUpdate();
        Debug.Log("RESTART");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {

        //AttemptReset();
        PlayerPrefs.SetFloat(HSprefsname, 100);
        Debug.Log("LEVEL COMPLETE WINDOW");
        CompleteLevelUI.SetActive(true);
        
        Debug.Log("LEVEL COMPLETEeeeeeeeeeeeeeeeeeeeeeeeeee WINDOW");
        
    }

}
