using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClick()
    {
        // Find the object with the Animator component
        GameObject sword = GameObject.Find("Sword");
        if (sword == null)
        {
            Debug.LogError("Cannot find object with Animator component");
            return;
        }

        // Get the Animator component and set the trigger
        Animator animator = sword.GetComponent<Animator>();
        if (animator == null)
        {
            Debug.LogError("Cannot find Animator component on object");
            return;
        }

        animator.SetBool("attacking", true);
    }
}
