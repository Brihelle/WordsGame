using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

using Random = UnityEngine.Random;

public class Die : MonoBehaviour{
    [SerializeField] TextMeshProUGUI pickedCharText;
    private char pickedChar;
    public string drawableLetters;
    //private char[] drawableLettersChars;
    public Action OnRoll;
    //private static WordBuilder wordBuilder;
    private WordBuilder wordBuilder;
    private Button button;

    //gamecontrol = FindObjectOfType<GameController>();
    //private void onenable()
    //{
    //    //onroll += addletteronclick;
    //}
    private void Start()
    {
        wordBuilder = FindObjectOfType<WordBuilder>();
        button = GetComponent<Button>();
    }

    //private void ondisable()
    //{
    //    onroll -= addletteronclick;
    //}

    //private void Start()
    //{
    //    CountDown(OnRoll);
    //}

    public char PickedChar
    {
        get
        {
            return pickedChar;
        }

        set
        {
            pickedChar = value;
            pickedCharText.text = value.ToString();
        }
    }

    // Use this for initialization
    //void Start () {
    //    char[] drawableLetters = new char[6] { 'A', 'B', 'C', 'D', 'E', 'F' };
    //    pickedChar.text = drawableLetters[Random.Range(0, 6)].ToString();
    //}

    //public void CountDown(Action OnCountDownCompleted)
    //{
    //    for(int i = 3; i>=0; i--)
    //    {
    //        Debug.Log(i);
    //    }
    //    OnCountDownCompleted.Invoke();
    //}

    public void SetUp()
    {
        pickedChar = drawableLetters[Random.Range(0, 6)];
        pickedCharText.text = pickedChar.ToString();
    }
	
    public void AddLetterOnClick()
    {
        wordBuilder.AddLetter(pickedChar);
        button.interactable = false;
    }
}
