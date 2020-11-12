using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    // Swich to scene "Menu"
    public void BackingToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
