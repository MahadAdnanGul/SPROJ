using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starts : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject suleman = GameObject.FindGameObjectWithTag("Suleman");
        
        
            suleman.SetActive(true);
        Debug.Log("scene0loaded");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
