using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FeelingText : MonoBehaviour
{
    public TextMeshProUGUI textItem;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("DialogueName"))
            textItem.text = PlayerPrefs.GetString("Name", "Bob");
        else
            textItem.text = "How is " + PlayerPrefs.GetString("Name", "Bob") + " feeling?";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
