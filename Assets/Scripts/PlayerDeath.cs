using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object") // if hostile object collides with player
        {
            Destroy(gameObject); // destroy player
        }
    }
}
