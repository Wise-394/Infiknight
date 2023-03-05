using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformmovescript : MonoBehaviour
{
    public float platformSpeed = 10;
    public float gone = -11;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=  Vector3.left * platformSpeed * Time.deltaTime;
        if (transform.position.x < gone) 
        {
            Destroy(gameObject);
        }
    }
}
