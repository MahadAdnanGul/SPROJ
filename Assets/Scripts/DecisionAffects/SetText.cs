using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetText : MonoBehaviour
{
    public TextMeshProUGUI txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void setup(string option)
    {
        txt.text = "While you think about " + option + ", you remember all the senior year events coming up.";
    }
}
