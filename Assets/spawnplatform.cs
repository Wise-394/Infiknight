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
    public float randomizer;
    public float slimespawner = 10;
    public float slimetimer;
    public GameObject slime;
    // Start is called before the first frame update
    void Start()
    {
        float lowestvalue = transform.position.y - offsetY;
        float hihestvalue = transform.position.y + offsetY;
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
            

        }
        else
        {
            randomizer = Random.Range(lowestvalue, hihestvalue);
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
            float lowestvalue = transform.position.y - offsetY;
            float hihestvalue = transform.position.y + offsetY;
            randomizer = Random.Range(lowestvalue, hihestvalue);
            spawnPlatform();
            timer = 0;
            if (birbspawner != birbspawnrate)
            {

                birbspawner = Random.Range(0, 2);
            }
            else if (birbspawner == birbspawnrate)
            {
            
                spawnBirb();
                birbspawner = Random.Range(0, 1);
            }
        }
        if (slimetimer < slimespawner)
        {
            slimetimer += Time.deltaTime;
        }
        else
        {
            spawnslime();
            slimetimer = 0;
        }
    }
    void spawnPlatform()
    {
        Instantiate(platform, new Vector3(transform.position.x, randomizer, transform.position.z), transform.rotation);
    }
    void spawnBirb()
    {
        Instantiate(birb, new Vector3(transform.position.x, randomizer + Random.Range(1,2), transform.position.z), transform.rotation);
    }
    void spawnslime()
    {
        if (Random.value > 0.5f)
        {
            Instantiate(slime, new Vector3(transform.position.x, randomizer + Random.Range(1, 5), transform.position.z), transform.rotation);
            Debug.Log("slime spawned");
        }
    }
}
