using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class WordBuilder : MonoBehaviour {
    [SerializeField] TextMeshProUGUI builtWord;
    private GameController gameController;
    char[] currentBuiltWord = new char[9];

    public void AddLetter(char letter)
    {
        for (int i = 0; i < currentBuiltWord.Length; i++)
        {
            if (currentBuiltWord.GetValue(i).Equals('\0'))
            {
                currentBuiltWord.SetValue(letter, i);
                break;
            }
        }
        builtWord.text = currentBuiltWord.ArrayToString();
        Debug.Log(builtWord.text);
    }

    public void OnConfirm()
    {
        Word word = new Word(builtWord.text);
        //GuessedWords guessedWords = FindObjectOfType<GuessedWords>();
        //guessedWords.insertNewWord(word.Content);
        gameController = GetComponent<GameController>();
        if (gameController.ConfirmWord(word))
        {
            OnReset();
        }
    }

    public void OnReset()
    {
        //for (int i = 0; i < currentBuiltWord.Length; i++)
        //{
        //    currentBuiltWord.SetValue("\0", i);
        //}
        Array.Clear(currentBuiltWord, 0, currentBuiltWord.Length);
        Debug.Log(currentBuiltWord);
        builtWord.text = currentBuiltWord.ArrayToString();
        gameController = GetComponent<GameController>();
        gameController.ResetWord();
    }
}
