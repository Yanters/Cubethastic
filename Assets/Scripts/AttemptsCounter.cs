using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AttemptsCounter : MonoBehaviour
{
    public string prefsname;
    public string HSprefsname;
    public Text AttemptsText;
    public Text HighScore;

    // Start is called before the first frame update
    void Start()
    {
        prefsname = SceneManager.GetActiveScene().name;
        HSprefsname = "HS" + SceneManager.GetActiveScene().name;
    }

    //Updating Attemp and HighScore
    void Update()
    {

        AttemptsText.text = "Attempt #" + PlayerPrefs.GetInt(prefsname, 0).ToString();
        HighScore.text = "High Score: " + PlayerPrefs.GetFloat(HSprefsname, 0).ToString() + "%";


    }
}
