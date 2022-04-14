using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GuessedWords : MonoBehaviour {
    public TextMeshProUGUI wordsListDisplay;
    private List<string> wordsList = new List<string>();

    public bool insertNewWord(string word)
    {
        if (!wordsList.Contains(word))
        {
            wordsList.Add(word);
            wordsListDisplay.text = wordsListDisplay.text + word + '\n';
            return true;
        }
        return false;
    }
    
}
