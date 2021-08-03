using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDay : MonoBehaviour
{
    public SpriteRenderer sr;
    public Sprite[] colors;
    Dictionary<string, int> dict = new Dictionary<string, int>();
    private void Awake()
    {
        dict.Add("Red", 0);
        dict.Add("Yellow",1);
        dict.Add("Green",2);
        dict.Add("Blue",3);
        dict.Add("Black",4);

    }
    private void Start()
    {
        string color = FindObjectOfType<GameManager>().cDay;

        sr.sprite = colors[dict[color]];
       
    }
}
