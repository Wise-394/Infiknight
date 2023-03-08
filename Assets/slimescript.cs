using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimescript : MonoBehaviour
{
    public float speed = 4;
    public bool bumped = false;
    public float gone = -11;
    public SpriteRenderer slimesprite;
    public GameObject knight;
    public SpriteRenderer knightrender;
    public LogicScript logic;
    public bool slimealive = true;

    // Start is called before the first frame update
    void Start()
    {
        knight = GameObject.FindGameObjectWithTag("knight");
        knightrender = knight.GetComponent<SpriteRenderer>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
   
        
       if (bumped == true) 
        {
         transform.position += Vector3.right * speed * Time.deltaTime;
            slimesprite.color = Color.red;
            Invoke("killslime", 0.15f);
        }
        else if (bumped == false)
        {
            transform.position += Vector3.left * 4 * Time.deltaTime;
        }
        if (transform.position.x < gone)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            bumped = true;
            slimealive = false;
            logic.AddScore();
            
        }
        if(collision.gameObject.layer == 6 && slimealive == true ) 
        {
            

                knightrender.color = Color.red;
                Invoke("killplayer", 0.2f);
                logic.gameOVer();
            
        }
      
    }
    public void killslime()
    {
        Destroy(gameObject);
    }
    public void killplayer()
    {
        Destroy(knight);
    }
}
