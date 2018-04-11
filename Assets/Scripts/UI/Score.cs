using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour 
{
    public delegate void ScoreUpdate(float value);
    public ScoreUpdate OnScoreUpdate;

    [SerializeField] Text scoreText;

    float scoring;
    public float Scoring
    {
        set { scoring = value; }
        get { return scoring; }
    }

    void Awake()
    {
        scoreText.text = "Score: 0";
        OnScoreUpdate += UpdateScore;
    }

    void UpdateScore(float newScore)
    {
        Scoring += newScore;
        scoreText.text = string.Format("Score: {0}", Scoring);
    }
}
