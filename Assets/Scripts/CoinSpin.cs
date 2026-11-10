using System;
using UnityEngine;
using UnityEngine.UIElements;

public class CoinSpin : MonoBehaviour
{
    public float rotation_speed;

    void Update()
    {
        transform.Rotate(Vector3.up, rotation_speed * Time.deltaTime);
    }
}
