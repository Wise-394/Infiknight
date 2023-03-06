using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public LogicScript logic;
    public float birbMoveSpeed = 10;
    public float gone = -11;
    // Start is called before the first frame update
    void Start()
    {
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7) 
        {
            Destroy(gameObject);
            logic.AddScore();
        }
    }
}
