using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_Sentence : MonoBehaviour
{
    public NewDialgoue dial;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        dial.messageArr[index] = "I would like to start this meeting by acknowledging " + PlayerPrefs.GetString("Name","Bob")+".";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
