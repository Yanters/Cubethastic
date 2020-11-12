using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public bool collided = false;
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        collided = false;

        if (collision.collider.tag == "Obstacle")
        {

            collided = true;
            movement.enabled = false;

            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
