using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UpdateScore(0);
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        DisplayScore();
    }
    
    public void DisplayScore()
    {
        scoreText.text = "Score: " + score;
    }
}
