using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplatform : MonoBehaviour
{
    public GameObject platform;
    public float timer;
    public float spawnrate = 1;
    public float offsetY;
    // Start is called before the first frame update
    void Start()
    {
        if(timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPlatform();
            timer = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPlatform();
            timer = 0;
        }
    }
    void spawnPlatform() 
    {
        float lowestvalue = transform.position.y - offsetY;
        float hihestvalue = transform.position.y + offsetY;
        Instantiate(platform, new Vector3(transform.position.x,Random.Range(lowestvalue,hihestvalue), transform.position.z), transform.rotation);
    }
}
