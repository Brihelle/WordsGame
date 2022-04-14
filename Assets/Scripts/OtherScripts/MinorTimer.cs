using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MinorTimer : MonoBehaviour {

    [SerializeField] TextMeshProUGUI timerValueText;

    float minutes = 0;
    float seconds = 3;
    float miliseconds = 0;

    void Update()
    {

        if (miliseconds <= 0)
        {
            if (seconds <= 0)
            {
                minutes--;
                seconds = 59;
            }
            else if (seconds >= 0)
            {
                seconds--;
            }

            miliseconds = 100;
        }

        miliseconds -= Time.deltaTime * 100;

        //Debug.Log(string.Format("{0}:{1}:{2}", minutes, seconds, (int)miliseconds));
        timerValueText.text = string.Format("{0}", seconds);
        if (minutes == 0 && seconds == 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
