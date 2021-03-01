using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class start_law : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        GameObject suleman = GameObject.FindGameObjectWithTag("Suleman");
        suleman.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
