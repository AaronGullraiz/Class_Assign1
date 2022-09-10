using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    public Rigidbody rb;
    public float speedForward, speedJump;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            velocity.z = speedForward;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            velocity.y = speedForward;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            velocity.z = -speedForward;
        }

        rb.AddForce(velocity,ForceMode.Impulse);
        velocity = Vector3.zero;
    }
}