using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoller : MonoBehaviour {
    public List <Die> dice;

    public void SetUpDice()
    {
        foreach (Die die in dice)
        {
            die.SetUp();
            Button button = die.GetComponent<Button>();
            button.interactable = true;
        }
    }
    public void ResetWord()
    {
        foreach (Die die in dice)
        {
            Button button = die.GetComponent<Button>();
            button.interactable = true;
        }
    }

}
