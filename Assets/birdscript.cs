using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public SpriteRenderer birb;
    public LogicScript logic;
    public float birbMoveSpeed = 10;
    public float gone = -11;
    public GameObject knight;
    public SpriteRenderer knightlogic;
    public bool birdalive = true;
    // Start is called before the first frame update
    void Start()
    {
        knight = GameObject.FindGameObjectWithTag("knight");
        knightlogic = knight.GetComponent<SpriteRenderer>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * birbMoveSpeed * Time.deltaTime;
        if (transform.position.x < gone)
        {
            Destroy(gameObject);
        }
    }
    public void killplayer()
    {
        Destroy(knight);
    }
    public void destroybirb() 
    {
        Destroy(gameObject);
        logic.AddScore();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7) 
        {
            birdalive = false;
            birb.color = Color.red;
            Invoke("destroybirb", 0.1f);
        }
        else if (collision.gameObject.layer == 6 && birdalive == true)
        {
            
            knightlogic.color = Color.red;
            Invoke("killplayer", 0.2f);
            logic.gameOVer();
        }
    }
}
