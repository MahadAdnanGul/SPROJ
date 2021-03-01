using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_Shoes : MonoBehaviour
{
    [SerializeField] SpriteRenderer girl_shoes;
    [SerializeField] GameObject girl_shoes_obj;
    [SerializeField] Sprite[] shoes_styles;
    [SerializeField] Vector2[] shoes_styles_vector;

    int current;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    public void ChangeShoes(int index)
    {
        girl_shoes.sprite = shoes_styles[index];

        girl_shoes_obj.transform.localPosition = shoes_styles_vector[index];

        if (PlayerPrefs.GetString("boy", "False") == "False")
        {
            PlayerPrefs.SetInt("GirlShoes", index);
        }
        else
        {
            PlayerPrefs.SetInt("BoyShoes", index);
        }

        
    }
}
