using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Quaternion quan = new Quaternion(0, 0, 0, 0);
    public Vector3 pozycja = new Vector3(-1, 1, 0);
    public Rigidbody rb;
    public float ForwardForce;
    public float SidewaysForce;
    public PlayerCollision PC;
    

    // Start is called before the first frame update
    void Start()
    {
        //PC = gameObject.GetComponent<PlayerCollision>();
        //rb.AddForce(xforce, yforce, zforce);

        // Debug.Log("Testing");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if ((Input.GetKey("d")|| Input.GetKey("right")) && rb.position.y<2 && rb.position.y > 0.5) // && !PC.collided
        {
            rb.AddForce(SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if ((Input.GetKey("a") || Input.GetKey("left")) && rb.position.y < 2 && rb.position.y > 0.5) // && !PC.collided
        {
            rb.AddForce(-SidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }


        if (rb.position.y < 0.5)
        {
            //Debug.Log("GAME OVER");
            PC.collided = true;
            FindObjectOfType<GameManager>().GameOver();            
        }


    }
}
