using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarewellSpecial : MonoBehaviour
{
    [SerializeField]GameObject Boy;
    [SerializeField] GameObject Girl;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("boy", "False") == "True")
        {
            Boy.SetActive(true);
        }
        else
        {
            Girl.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
