using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetDialogue : MonoBehaviour
{
    public bool resetTrigger;
    public NewDialgoue trigger;
    public GameObject newTrigger;
    public string[] messages;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        if(resetTrigger)
        {
            trigger.ResetDialogues(messages, newTrigger);
        }
    }
}
