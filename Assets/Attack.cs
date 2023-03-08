using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Attack : MonoBehaviour
{
    public CapsuleCollider2D myCapsuleCollider2d;
    public Animator animator;
    public float reqtime = 1;
    public float timer;
    public bool attacking = true;
    public attacksound myattacksound;
    // Start is called before the first frame update
    void Start()
    {
        myattacksound = GameObject.FindGameObjectWithTag("sound1").GetComponent<attacksound>();
    }

    // Update is called once per frame
    void Update()
    {
        if(attacking == true) 
        {
            
            Invoke("delaymethod", 0.5f);
        }
    }
    public void OnClick()
    {
        myCapsuleCollider2d.enabled = true;
        gameObject.SetActive(true);
        animator.SetBool("Attacking", true);
        playtanginamo();
        attacking = true;
       
    }
    public void delaymethod() 
    {
        myCapsuleCollider2d.enabled = false;
        animator.SetBool("Attacking", false);
        attacking = false;
        gameObject.SetActive(false);
    }
    public void playtanginamo() 
    {
        myattacksound.playsound();
    }
}
