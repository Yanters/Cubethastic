﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
    public GameManager GM;
    public void LoadNextLevel()
    {
        Debug.Log("OFF OFF OFF TRYS");
        GM.AttemptReset();
        Debug.Log("LOADING NEW SCENE /n LOADING NEW SCENE");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        Debug.Log("LOADED NEW SCENE /n LOADED NEW SCENE");
        
        Debug.Log("WLACZYLEM TRYS");
        
    }
}
