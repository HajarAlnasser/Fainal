using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playermovement : MonoBehaviour
{
    bool jump;
    public Rigidbody rb;
    Vector2 Movement;
    public void Playermov(InputAction.CallbackContext context)
    {
        Movement = context.ReadValue<Vector2>();
    }
    public void Jump(InputAction.CallbackContext context)
    {
        jump = context.action.triggered;
    }
    private void Update()
    {
        Vector3 Mov = new Vector3(Movement.x, -0.5f, Movement.y);
        rb.velocity = Mov * 5;
        if (jump) {
            rb.AddForce(Vector3.up * 400);

        }
    }
}
