﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SetName : MonoBehaviour
{
    public TMP_InputField nameText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Done()
    {
        PlayerPrefs.SetString("Name", nameText.text);
    }
    public void StartGame()
    {
        FindObjectOfType<GameManager>().StartGame();
    }
}
