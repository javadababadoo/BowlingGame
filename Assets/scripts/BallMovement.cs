using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody ball;
    public int force;

    // Update is called once per frame
    void FixedUpdate()
    {
        ball.AddForce(0, 0, 140);
    }
}
