using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnplatform : MonoBehaviour
{
    public GameObject birb;
    public GameObject platform;
    public float timer;
    public float spawnrate = 1;
    public float offsetY;
    public float birbspawnrate = 1;
    public float birbspawner = 0;
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
            if (birbspawner != birbspawnrate)
            {
                birbspawner = Random.Range(0,2);
            }
            else if (birbspawner == birbspawnrate)
            {
                spawnBirb();
                birbspawner = Random.Range(0, 1);
            }
        }
    }
    void spawnPlatform() 
    {
        float lowestvalue = transform.position.y - offsetY;
        float hihestvalue = transform.position.y + offsetY;
        Instantiate(platform, new Vector3(transform.position.x,Random.Range(lowestvalue,hihestvalue), transform.position.z), transform.rotation);
    }
    void spawnBirb() 
    {
        float lowestvalue = transform.position.y - offsetY;
        float hihestvalue = transform.position.y + offsetY;
        Instantiate(birb, new Vector3(transform.position.x, Random.Range(lowestvalue, hihestvalue), transform.position.z), transform.rotation);
    }
}
