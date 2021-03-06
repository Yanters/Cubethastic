﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Cheats : MonoBehaviour
{
    public IsButtonAvalible IBA;
    public static bool IsOn;

    private void Start()
    {
        // After App restart load shadow to button 'Cheats' if it's On
        if (IsOn && transform.name == "Cheats")
        {
            transform.GetComponent<Shadow>().effectColor = new Color32(52, 226, 7, 181);
        }
        else if(!IsOn && transform.name == "Cheats")
        {
            transform.GetComponent<Shadow>().effectColor = new Color32(75, 75, 75, 90);
        }
    }
    //Putting shadow on the button 'Cheats' Green - ON, Grey = OFF
    public void TurnCheats()
    {
        if(IsOn)
        {
            transform.GetComponent<Shadow>().effectColor = new Color32(52, 226, 7, 181);
        }
        else
        {
            transform.GetComponent<Shadow>().effectColor = new Color32(75, 75, 75, 90);
        }
        
    }
    // Swich On/Off
    public void ONOF()
    {
        if(IsOn)
        {
            IsOn = false;
            Debug.Log("CHEATS OFF");
        }
        else
        {
            IsOn = true;
            Debug.Log("CHEATS ON");
        }
        TurnCheats();
        IBA.Avalible();
    }
   
}
