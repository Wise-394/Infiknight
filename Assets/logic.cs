using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class logic : MonoBehaviour
{
    public int playerScore;
    public Text scoretext;
    public void gameOver() 
    {

    }
    public void addScore() 
    {
        playerScore += 1;
        scoretext.text = playerScore.ToString();

    }
}
