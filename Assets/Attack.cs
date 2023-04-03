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
        myCapsuleCollider2d = GameObject.FindGameObjectWithTag("Sword").GetComponent<CapsuleCollider2D>();
        Invoke(nameof(Delaymethod), 0.01f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onClickAttack()
    {
        Debug.Log("omsim");
        myCapsuleCollider2d.enabled = true;
        gameObject.SetActive(true);
        animator.SetBool("Attacking", true);
        playtanginamo();
        attacking = true;

        if (attacking == true)
        {

            Invoke(nameof(Delaymethod), 0.5f);
        }
    }
    public void Delaymethod()
    {
        Debug.Log(" mooooooooooooooooooooooo");
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
