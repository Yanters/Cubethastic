using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToOptions : MonoBehaviour
{
   public void ToOptions()
    {
        SceneManager.LoadScene("Options");
    }
}
