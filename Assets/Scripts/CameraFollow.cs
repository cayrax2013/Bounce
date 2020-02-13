using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform playerBall;
   

    private void FixedUpdate()
    {
        transform.position = new Vector3(playerBall.position.x, playerBall.position.y, transform.position.z);
    }
}
