﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingScene : MonoBehaviour
{
    public void ExitApplication()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }
}