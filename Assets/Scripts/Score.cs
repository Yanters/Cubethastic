using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public Transform player;
    public Transform EndingPoint;
    public Text scoreText;
    public float scoreProcentage;
    public PlayerCollision PC;
  

  
    // Start is called before the first frame update
    void Start()
    {
       
    }

    

    // Update is called once per frame
    void Update()
    {
        if(!PC.collided)
        {
            scoreProcentage = (((player.position.z) / EndingPoint.position.z) * 100);
        }
        
        if (scoreProcentage>=100)
        {
            scoreProcentage = 100;
          
            
           
        }
       
       
        scoreText.text = scoreProcentage.ToString("0")+"%" ;   
    }
}
