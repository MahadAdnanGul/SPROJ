using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PDCTable : MonoBehaviour
{
    public SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().PDC(sr);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
