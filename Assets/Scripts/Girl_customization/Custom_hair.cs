using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_hair : MonoBehaviour
{
    [SerializeField] SpriteRenderer girl_hair;
    [SerializeField] GameObject girl_hair_obj;
    [SerializeField] Sprite[] hair_styles;
    [SerializeField] Vector2[] hair_styles_vector;
   
    int current;

    private void Start()
    {
        current = 0;
    }

    // Start is called before the first frame update
    public void ChangeHair(int index)
    {
        girl_hair.sprite = hair_styles[index];
      
        girl_hair_obj.transform.localPosition = hair_styles_vector[index];

        if (PlayerPrefs.GetString("boy", "False") == "False")
        {
            PlayerPrefs.SetInt("GirlHair", index);
        }
        else
        {
            PlayerPrefs.SetInt("BoyHair", index);
        }

        //if (current==hair_styles.Length-1)
        //{
        //    current = 0;
           
        //}
       // else
        //{
        //    current++;
        //}
    }


}
