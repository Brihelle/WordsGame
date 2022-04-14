using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LanguageChoice : MonoBehaviour {
    public static string chosenLanguage;
    public GameObject languageChoiceObject;
    public TextMeshProUGUI languagePicklistChoice;

    // Use this for initialization
    void Start () {
		if(chosenLanguage != null)
        {
            languageChoiceObject.SetActive(true);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onLanguageChoice()
    {
        chosenLanguage = languagePicklistChoice.text;
        languageChoiceObject.SetActive(false);
    }
}
