using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameModeChoice : MonoBehaviour {

	public void onClickClassicMode()
    {

    }
    public void onClickZenMode()
    {

    }
    public void onClickTrainingMode()
    {
        SceneManager.LoadScene(1);
    }
}
