using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsController : MonoBehaviour {

    public GameObject languageChoiceObject;
    private LanguageChoice languageChoice;
    public GameObject gameModeChoiceObject;
    private GameModeChoice gameModeChoice;
    public GameObject minorTimer;

    // Use this for initialization
    void Start () {
        languageChoice = languageChoiceObject.GetComponent<LanguageChoice>();
        gameModeChoice = gameModeChoiceObject.GetComponent<GameModeChoice>();
        minorTimer.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onLanguageChoice()
    {
        languageChoice.onLanguageChoice();
        gameModeChoiceObject.SetActive(true);
    }

    public void onClassicModeGameChoice()
    {
        gameModeChoice.onClickClassicMode();
    }

    public void onZenModeGameChoice()
    {
        gameModeChoice.onClickZenMode();
    }

    public void onTrainingModeGameChoice()
    {
        languageChoiceObject.SetActive(false);
        gameModeChoiceObject.SetActive(false);
        minorTimer.SetActive(true);
    }
}
