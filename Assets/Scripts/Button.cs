using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string desiredScenePath;
    public bool quitButton;
    public void buttonPressed()
    {
        if(quitButton)
        {
            Application.Quit();
        }
        else
        {
            SceneManager.LoadScene(desiredScenePath);
        }
        
    }
}
