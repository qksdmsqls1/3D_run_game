using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Update()
    {
        score += (int)(Time.deltaTime * 10);
        scoreText.text = "Score: " + score.ToString();
    }
}
