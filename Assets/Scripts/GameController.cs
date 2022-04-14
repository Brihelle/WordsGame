using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    private Die die;
    private DiceRoller diceRoller;
    private WordManager wordManager;

    // Use this for initialization
    void Start () {
        wordManager = GetComponent<WordManager>();
        diceRoller = GetComponent<DiceRoller>();
        RollDice();
    }

    public void RollDice()
    {
        diceRoller.SetUpDice();
    }

    public void ResetWord()
    {
        diceRoller.ResetWord();
    }

    public void AddLetterOnClick()
    {
        die = FindObjectOfType<Die>();
        die.AddLetterOnClick();
    }

    public bool ConfirmWord(Word word)
    {
        if (wordManager.checkValidWord(word.Content))
        {
            GuessedWords guessedWords = FindObjectOfType<GuessedWords>();
            if (guessedWords.insertNewWord(word.Content))
            {
                Score score = FindObjectOfType<Score>();
                score.IncreaseScore(word);
                Timer timer = FindObjectOfType<Timer>();
                timer.Reset();
                return true;
            }
        }
        return false;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
