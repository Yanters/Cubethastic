using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;

    // If EndTrigger is Triggered it will load next level
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER BOX ENDING");
        gameManager.CompleteLevel();
    }
}
