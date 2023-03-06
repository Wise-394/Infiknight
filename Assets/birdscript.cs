using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public float birbMoveSpeed = 10;
    public float gone = -11;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
