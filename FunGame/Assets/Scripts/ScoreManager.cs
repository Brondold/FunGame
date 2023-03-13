using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    public Text highScoreText;

    int score = 0;
    int highScore = 0;
   

    void Start()
    {
        scoreText.text = score.ToString() + "POINTS";
        highScoreText.text = highScore.ToString();
    }

    public void Update()
    {
        scoreText.text = "Score : " + score;
    }
}
