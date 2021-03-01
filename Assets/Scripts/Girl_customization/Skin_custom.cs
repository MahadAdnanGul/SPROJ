using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin_custom : MonoBehaviour
{
    int current;
    [SerializeField] SpriteRenderer skin;
    [SerializeField] SpriteRenderer Hand;
    [SerializeField]  Vector3 [] colors;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    public void ColorChange(int index)
    {
        skin.color = new Color(colors[index].x / 255f, colors[index].y / 255f, colors[index].z / 255f);
        Hand.color = skin.color;
        PlayerPrefs.SetInt("GirlColor", index);
       
    }
}
