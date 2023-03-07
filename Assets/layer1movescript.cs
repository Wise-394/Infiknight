using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class layer1movescript : MonoBehaviour
{
    public float speed;
    public float teleportposition = 22f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < -22)
        {
            TeleportObject();
        }
    }
    public void TeleportObject()
    {
        Vector2 currentPosition = transform.position;
        Vector3 teleportPosition = new Vector3(teleportposition, currentPosition.y, 3);
        transform.position = teleportPosition;
    }
}
