using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameOptionsController : MonoBehaviour {
    public GameObject endGameOptionsObject;
    private EndGameOptions endGameOptions;
    public GameObject minorTimer;

    // Use this for initialization
    void Start ()
    {
        endGameOptions = FindObjectOfType<EndGameOptions>();
        minorTimer.SetActive(false);
    }

    public void onClickPlayAgain()
    {
        endGameOptionsObject.SetActive(false);
        minorTimer.SetActive(true);
    }

    public void onClickMainMenu()
    {
        endGameOptions.onBackToMenu();
    }

    public void onClickExitDesktop()
    {
        endGameOptions.onExitGame();
    }

}
