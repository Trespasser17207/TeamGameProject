using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public float speed; // float for speed
    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime; // move floor on x axis over time
    }
    private void Update()
    {
        if (transform.position.x < -15) // if floor goes under - 15 units on x axis
        {
            Destroy(gameObject); // destroy tha floor
        }
    }
   
}

