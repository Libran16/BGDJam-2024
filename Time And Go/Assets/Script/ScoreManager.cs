using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI hiScoreText;
    int score;
    int hscore;

    void Start()
    {
        scoreText.text = "Score : " + score;
        if(PlayerPrefs.HasKey("HighScore"))
        {
            hscore = PlayerPrefs.GetInt("HighScore");
        }
    }

    public void IncreaseScore()
    {
        score ++;
        scoreText.text = "Score : " + score;
    }

    public void HighScore()
    {
        if(score > hscore)
        {
            hscore = score;
            PlayerPrefs.SetInt("HighScore", hscore);
        }
        hiScoreText.text = "Hi-Score : " + hscore;
    }
}
