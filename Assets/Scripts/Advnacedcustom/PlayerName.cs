using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerName : MonoBehaviour
{
    public TextMeshProUGUI textItem;
    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.CompareTag("DialogueName"))
        textItem.text = PlayerPrefs.GetString("Name", "Bob");
        else if(gameObject.CompareTag("FeelingText"))
            textItem.text = "How is " + PlayerPrefs.GetString("Name", "Bob") + " feeling?";
        else if(gameObject.CompareTag("DecisionText"))
        {
            textItem.text = "What does " + PlayerPrefs.GetString("Name", "Bob") + " do?";
        }
        else
            textItem.text="What is "+ PlayerPrefs.GetString("Name", "Bob")+" thinking?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
