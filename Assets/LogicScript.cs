using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject knight;
    public TextMeshProUGUI skillissue;
    public int playerScore = 0;
    public Text scoretext;
    public SpriteRenderer knightrender;
    public void Start()
    {
        knightrender = knight.GetComponent<SpriteRenderer>();
    }
    public void AddScore() 
    {
        playerScore++;
        scoretext.text = playerScore.ToString();

    }
    public void gameOVer() 
    {
        knightrender.color = Color.red;
        skillissue.gameObject.SetActive(true);
        
    }
    public void playAgain() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void exitgame() 
    {
        Application.Quit();
    }
}
