using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Object") // if hostile object collides with player
        {
            SceneManager.LoadScene("DeathScreen");
            Destroy(gameObject); // destroy player
        }
    }
}
