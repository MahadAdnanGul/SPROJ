using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceFeedback : MonoBehaviour
{
    public GameObject choice;
    public GameObject trigger;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Done()
    {
        trigger.SetActive(true);
        choice.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
