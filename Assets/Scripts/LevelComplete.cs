using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameManager GM;

    //Loading Next Level
    public void LoadNextLevel()
    {
        GM.AttemptReset();
        Debug.Log("LOADING NEW SCENE");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
