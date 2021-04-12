using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiceBoardGender : MonoBehaviour
{
    [SerializeField] GameObject boy;
    [SerializeField] GameObject girl;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("boy", "False") == "True")
        {
            boy.SetActive(true);
        }
        else
        {
            girl.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPress()
    {
        FindObjectOfType<GameManager>().IncreaseLevelProgress();
    }
}
