using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {
    public TextMeshProUGUI scoreText;
    private int scoreValue;

    public int ScoreValue
    {
        get
        {
            return scoreValue;
        }

        set
        {
            scoreValue = value;
            scoreText.text = value.ToString();
        }
    }

    public void IncreaseScore(Word word)
    {
        scoreValue = scoreValue + word.Score;
        scoreText.text = scoreValue.ToString();
        //Debug.Log(word.Length);
        //if (word.Length == 4)
        //{
        //    Debug.Log("La parola è lunga 4");
        //    scoreValue = scoreValue + 10;
        //    scoreText.text = scoreValue.ToString();
        //}
        //else if (word.Length > 4)
        //{
        //    Debug.Log("La parola è più lunga di 4");
        //    for (int i = 3; i < word.Length; i++)
        //    {
        //        scoreValue = scoreValue + 10;
        //    }
        //    scoreText.text = scoreValue.ToString();
        //}
    }
}
