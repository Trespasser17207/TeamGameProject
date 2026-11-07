using UnityEngine;

public class PlayerScoring : MonoBehaviour
{
    float timer;
    float time = 14.0f;

    public int score;

    private void Start()
    {
        timer = time;
    }

    private void Update()
    {
        timer -= 0.01f;
        if (timer <= 0.0f)
        {
            Debug.LogWarning("Score added");
            score++;
            timer = time;
        }
    }
}
