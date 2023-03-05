using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public Rigidbody2D newrigidbody;
    // Start is called before the first frame update
    void Start()
    {
        newrigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
    }
  
 }
    
