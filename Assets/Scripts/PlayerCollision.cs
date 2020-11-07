using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Quaternion quan = new Quaternion(0, 0, 0, 0);
    public Vector3 pozycja = new Vector3(-1, 1, 0);
    public bool collided = false;
    public PlayerMovement movement;
  
    private void OnCollisionEnter(Collision collision)
    {
        

        collided = false;
        //Debug.Log(collision.collider.name);
        if (collision.collider.tag == "Obstacle")
        {
            ///////////////////////collided = true;
            collided = true;
            movement.enabled = false;
            ////////////////////while(movement.ForwardForce>0)
            ////////////////////{
            ////////////////////    movement.ForwardForce = (movement.ForwardForce -3)* Time.deltaTime;
            ////////////////////}
            /////Wyłączenie skryptu
           // movement.enabled = false;
            //movement.rb.velocity = Vector3.zero;
            FindObjectOfType<GameManager>().GameOver();
           // transform.SetPositionAndRotation(pozycja, quan);
           // movement.enabled = false;
        }
    }
}
