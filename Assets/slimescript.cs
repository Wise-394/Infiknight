using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slimescript : MonoBehaviour
{
    public float speed = 4;
    public bool bumped = false;
    public SpriteRenderer slimesprite;
        
    // Start is called before the first frame update
    void Start()
    {
        
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
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            bumped = true;
            
        }
      
    }
    public void killslime()
    {
        Destroy(gameObject);
    }
}
