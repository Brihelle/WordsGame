using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Word {

    private int score;
    private string content;

    public Word(string text)
    {
        content = text;
    }

    public int Score
    {
        get
        {
            if (content.Length == 4)
            {
                score = score + 10;
            }
            else if (content.Length > 4)
            {
                Debug.Log("La parola è più lunga di 4");
                for (int i = 3; i < content.Length; i++)
                {
                    score = score + 10;
                }
            }
            return score;
        }

        
        set
        {
            score = value;
        }
    }

    public string Content
    {
        get
        {
            return content;
        }

        set
        {
            content = value;
        }
    }
}
