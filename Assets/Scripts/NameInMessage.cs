using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameInMessage : MonoBehaviour
{
    // Start is called before the first frame update
    public NewDialgoue dialogue;

    private void Start()
    {
        dialogue.messageArr[0] = "Hi my name is " + PlayerPrefs.GetString("Name", "Bob") + "!";
    }
}
