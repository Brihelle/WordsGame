using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameOptions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}



    public void onPlayAgain()
    {

    }

    public void onBackToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void onExitGame()
    {
        Application.Quit();
    }
}
