using UnityEngine;
using TMPro;

public class PlayerScoring : MonoBehaviour
{
    float timer;
    float time = 14.0f;

    public int score;
    public TextMeshProUGUI scoreLabel;


    private void Start()
    {
        timer = time;
    }

    private void Update()
    {
        scoreLabel.text = "Score: " + score;
        timer -= 0.01f;
        if (timer <= 0.0f)
        {
            Debug.LogWarning("Score added");
            score++;
            timer = time;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coins")
        {
            Debug.LogWarning("Obtained coin");
            score += 50;
            Destroy(other.gameObject);
        }
    }
}
