using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class logicscreeeeeeeept : MonoBehaviour
{
    public GameObject black;
    public GameObject text;
    public bool switcher = false;
 public void onclick()
    {
        if (switcher == false)
        {
            black.SetActive(true);
            text.SetActive(true);
            switcher = true;
        }
        else
        {
            Invoke("autooff", 10f);
            black.SetActive(false);
            text.SetActive(false);
            switcher = false;
        }
    }
    public void autooff() 
    {
        black.SetActive(false);
        text.SetActive(false);
        switcher = false;
    }
   
}
