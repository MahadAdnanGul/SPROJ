using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_shirt : MonoBehaviour
{
    [SerializeField] SpriteRenderer girl_shirt;
    [SerializeField] GameObject girl_shirt_obj;
    [SerializeField] Sprite[] shirt_styles;
    [SerializeField] Vector2[] shirt_styles_vector;

    int current;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    public void ChangeShirt(int index)
    {
        girl_shirt.sprite = shirt_styles[index];

        girl_shirt_obj.transform.localPosition = shirt_styles_vector[index];

        if(PlayerPrefs.GetString("boy","False")=="False")
        {
            PlayerPrefs.SetInt("GirlShirt", index);
        }
        else
        {
            PlayerPrefs.SetInt("BoyShirt", index);
        }
        

       /* if (current == shirt_styles.Length - 1)
        {
            current = 0;

        }
        else
        {
            current++;
        }*/
    }
}
