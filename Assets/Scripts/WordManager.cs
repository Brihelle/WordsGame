using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class WordManager : MonoBehaviour {
    List<string> availableWordsList = new List<string>();

    // Use this for initialization
    void Start () {
		string[] availableWords = File.ReadAllLines("C:/Users/BriBl/Desktop/UnityLearning/Tools/Word-it/Parole/all_words_withoutBadWords.txt");
        availableWordsList.AddRange(availableWords);
    }
	
	public bool checkValidWord(string word)
    {
        if (availableWordsList.Contains(word.ToLower()) && word.Length >= 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
