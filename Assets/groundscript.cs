using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundscript : MonoBehaviour
{
    public float jumpHeight = 10;
    public float doubleJumpHeight = 5;
    bool onGround = false;
    public Rigidbody2D myrigidbody;
    public int doublejump = 1;
    public Animator animator;
    public LogicScript logic;
    public bool isalive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        myrigidbody = transform.parent.GetComponent<Rigidbody2D>();
        animator = transform.parent.GetComponent<Animator>();
 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1) & onGround && isalive)
        {
           myrigidbody.velocity = Vector2.up * jumpHeight;
            animator.SetBool("jumping", true);
            onGround = false;
        }
        else if (Input.GetMouseButtonDown(1) && doublejump > 0 && isalive)
        {
            animator.SetTrigger("djump");
            myrigidbody.velocity = Vector2.up * doubleJumpHeight;
            animator.SetBool("jumping", true);
            onGround = false;
            doublejump--;
        }
        if (gameObject.transform.position.y < -6) 
        {
            isalive = false;
            logic.gameOVer();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            onGround = true;
            animator.SetBool("jumping", false);
            doublejump = 1;
        }
    }
    public void onclick() 
    {
        if (onGround && isalive)
        {
            myrigidbody.velocity = Vector2.up * jumpHeight;
            animator.SetBool("jumping", true);
            onGround = false;
        }
        else if (doublejump > 0 && isalive)
        {
            animator.SetTrigger("djump");
            myrigidbody.velocity = Vector2.up * doubleJumpHeight;
            animator.SetBool("jumping", true);
            onGround = false;
            doublejump--;
        }
    }

}
