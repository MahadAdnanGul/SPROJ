using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Custom_trouser : MonoBehaviour
{
    [SerializeField] SpriteRenderer girl_trouser;
    [SerializeField] GameObject girl_trouser_obj;
    [SerializeField] Sprite[] trouser_styles;
    [SerializeField] Vector2[] trouser_styles_vector;

    int current;
    // Start is called before the first frame update
    void Start()
    {
        current = 0;
    }

    // Update is called once per frame
    public void ChangeTrouser(int index)
    {
        girl_trouser.sprite = trouser_styles[index];

        girl_trouser_obj.transform.localPosition = trouser_styles_vector[index];

        if (PlayerPrefs.GetString("boy", "False") == "False")
        {
            PlayerPrefs.SetInt("GirlTrouser", index);
        }
        else
        {
            PlayerPrefs.SetInt("BoyTrouser", index);
        }

        
    }
}
