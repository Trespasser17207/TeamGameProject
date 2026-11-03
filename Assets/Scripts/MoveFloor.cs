using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public float speed;
    private void FixedUpdate()
    {
        transform.position -= new Vector3(speed, 0, 0) * Time.deltaTime;
    }
}
