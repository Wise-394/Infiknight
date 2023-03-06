using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoretext;
    public void AddScore() 
    {
        playerScore++;
        scoretext.text = playerScore.ToString();

    }
    public void gameOVer() 
    {
    }
}
