using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GirlGetOutfitIllusion : MonoBehaviour
{
    // Start is called before the first frame update
    Image girl_hair;
    [SerializeField] GameObject girl_hair_obj;
    Sprite[] hair_styles;
    Vector2[] hair_styles_vector;
    int HairIndex;
    //Hair

    //Shirt
    Image girl_shirt;
    [SerializeField] GameObject girl_shirt_obj;
    Sprite[] shirt_styles;
    Vector2[] shirt_styles_vector;
    int ShirtIndex;
    //Shirt


    //Skin
    Image skin;
    Vector3[] colors;
    int SkinIndex;
    //Skin

    // Start is called before the first frame update


    private void Awake()
    {
        //Hair
        hair_styles = new Sprite[4];
        hair_styles[0] = Resources.Load<Sprite>("Girl/Illusion/Hair/hair-1");
        hair_styles[1] = Resources.Load<Sprite>("Girl/Illusion/Hair/hair-2");
        hair_styles[2] = Resources.Load<Sprite>("Girl/Illusion/Hair/hair-3");
        hair_styles[3] = Resources.Load<Sprite>("Girl/Illusion/Hair/hair-4");

        hair_styles_vector = new Vector2[4];
        hair_styles_vector[0] = new Vector2(7f, 89f);
        hair_styles_vector[1] = new Vector2(10f, 67f);
        hair_styles_vector[2] = new Vector2(14f, 65f);
        hair_styles_vector[3] = new Vector2(4f, 80f);

        HairIndex = PlayerPrefs.GetInt("GirlHair", 0);
        //Hair


        //Shirt
        shirt_styles = new Sprite[4];
        shirt_styles[0] = Resources.Load<Sprite>("Girl/Illusion/Shirt/shirt-1");
        shirt_styles[1] = Resources.Load<Sprite>("Girl/Illusion/Shirt/shirt-2");
        shirt_styles[2] = Resources.Load<Sprite>("Girl/Illusion/Shirt/shirt-3");
        shirt_styles[3] = Resources.Load<Sprite>("Girl/Illusion/Shirt/shirt-4");

        shirt_styles_vector = new Vector2[4];
        shirt_styles_vector[0] = new Vector2(0f, -36f);
        shirt_styles_vector[1] = new Vector2(0f, -36f);
        shirt_styles_vector[2] = new Vector2(0f, -36f);
        shirt_styles_vector[3] = new Vector2(0f, -28f);

        ShirtIndex = PlayerPrefs.GetInt("GirlShirt", 0);
        //Shirt



        //Skin
        colors = new Vector3[4];
        colors[0] = new Vector3(244f, 194f, 157f);
        colors[1] = new Vector3(242f, 178f, 126f);
        colors[2] = new Vector3(224f, 154f, 101f);
        colors[3] = new Vector3(168f, 106f, 64f);

        SkinIndex = PlayerPrefs.GetInt("GirlColor", 0);

        //Skin
    }
    void Start()
    {
        //init   
        girl_hair = girl_hair_obj.GetComponent<Image>();
        girl_shirt = girl_shirt_obj.GetComponent<Image>();
        skin = gameObject.GetComponent<Image>();
        //init

        //outfitload
        girl_hair.sprite = hair_styles[HairIndex];
        girl_hair_obj.transform.localPosition = hair_styles_vector[HairIndex];

        girl_shirt.sprite = shirt_styles[ShirtIndex];
        girl_shirt_obj.transform.localPosition = shirt_styles_vector[ShirtIndex];



        skin.color = new Color(colors[SkinIndex].x / 255f, colors[SkinIndex].y / 255f, colors[SkinIndex].z / 255f);





        //outfitload



    }
}
