using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite_select_trans : MonoBehaviour
{
    [SerializeField] Sprite boy;
    [SerializeField] Sprite girl;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetString("boy","False")=="True")
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = boy;
        }
        else 
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = girl;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
