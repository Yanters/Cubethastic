using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;


    // Camera following player
    void Update()
    {
        //transform z małej to odnosi się do obiektu w którym jest skrypt
        transform.position = player.position + offset;
    }
}
