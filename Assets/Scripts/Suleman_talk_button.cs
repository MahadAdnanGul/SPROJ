using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Suleman_talk_button : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI objective;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (objective.text != "Talk to Sir Suleman ")
        {
            if(gameObject.activeSelf)
                gameObject.SetActive(false);
        }
            
    }
}
