using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float jumpVelocity;
    bool onFloor;

    private void Update()
    {
        //jump
        if (Input.GetKeyDown(KeyCode.Space) && onFloor)
        {
            rb.AddForce(new Vector3(0, jumpVelocity, 0));
        }
        checkFloor();
    }

    void checkFloor()
    {
        // shoots a ray down from the players origin
        if (Physics.Raycast(transform.position, Vector3.down, out RaycastHit hit, 2f))
        {
            // checks if the ray is hitting the floor or not
            if (hit.collider.gameObject.tag == "floor" && rb.linearVelocity.y == 0)
            {
                onFloor = true;
            }
            else
            {
                onFloor = false;
            }
        }
        else
        {
            onFloor = false;
        }
    }
}
