using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    public float cloudspeed;
    public float gone = -13;
    public float teleportposition = 13f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * cloudspeed * Time.deltaTime;
        if(transform.position.x < gone) 
        {
            TeleportObject();
        }
    }
    public void TeleportObject()
    {
        Vector2 currentPosition = transform.position; 
        Vector2 teleportPosition = new Vector2(teleportposition, currentPosition.y); 
        transform.position = teleportPosition; 
    }
}
