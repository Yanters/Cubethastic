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

    void Start()
    {
        
        //PlayerPrefs.SetInt("Attempt", 1); // fuck logic
        int SaveAttempt = PlayerPrefs.GetInt("Attempt");
    }
    //void Update()
    //{
    //    if(CompleteLevelUI.)
    //}

    public void AttemptReset()
    {
        PlayerPrefs.SetInt("Attempt", 1);
        SaveAttempt = PlayerPrefs.GetInt("Attempt");
    }
    public void AttemptUpdate()
    {
        SaveAttempt = PlayerPrefs.GetInt("Attempt") + 1;
        PlayerPrefs.SetInt("Attempt", SaveAttempt);
    }

    public void GameOver()
    {
        
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("RestartGame", RestartDelay);
            
            //RestartGame();
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
        
        AttemptReset();
        
        Debug.Log("LEVEL COMPLETE WINDOW");
        CompleteLevelUI.SetActive(true);
        
        Debug.Log("LEVEL COMPLETEeeeeeeeeeeeeeeeeeeeeeeeeee WINDOW");
        
    }

}
