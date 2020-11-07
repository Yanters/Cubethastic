using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AttemptsCounter : MonoBehaviour
{
    public string prefsname;
    public Text AttemptsText;
    // Start is called before the first frame update
    void Start()
    {
        prefsname = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
           AttemptsText.text = "Attempt #" + PlayerPrefs.GetInt(prefsname, 0).ToString();
         
       
     
    }
}
