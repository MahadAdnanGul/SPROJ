using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Farewell : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI titleText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("Name", "bob");
        titleText.text = PlayerPrefs.GetString("Title", "Homo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
