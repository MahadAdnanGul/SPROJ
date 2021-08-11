using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomizeBoySpecial2 : MonoBehaviour
{
    // Start is called before the first frame update
    SpriteRenderer girl_hair;
    [SerializeField] GameObject girl_hair_obj;
    Sprite[] hair_styles;
    Vector2[] hair_styles_vector;
    Vector2[] hair_scales_vector;
    int HairIndex;
    //Hair

    //Shirt
    SpriteRenderer girl_shirt;
    [SerializeField] GameObject girl_shirt_obj;
    Sprite[] shirt_styles;
    Vector2[] shirt_styles_vector;
    Vector2[] shirt_scales_vector;
    int ShirtIndex;
    //Shirt


    //Skin
    SpriteRenderer skin;
    Vector3[] colors;
    int SkinIndex;
    //Skin

    // Start is called before the first frame update


    private void Awake()
    {
        //Hair
        hair_styles = new Sprite[5];
        hair_styles[0] = Resources.Load<Sprite>("Boy/Special2/Hair/hair-1");
        hair_styles[1] = Resources.Load<Sprite>("Boy/Special2/Hair/hair-2");
        hair_styles[2] = Resources.Load<Sprite>("Boy/Special2/Hair/hair-3");
        hair_styles[3] = Resources.Load<Sprite>("Boy/Special2/Hair/hair-4");
        hair_styles[4] = Resources.Load<Sprite>("Boy/Special2/Hair/hair-5");


        hair_styles_vector = new Vector2[5];
        hair_styles_vector[0] = new Vector2(-0.33f, 1f);
        hair_styles_vector[1] = new Vector2(-0.13f, 1.59f);
        hair_styles_vector[2] = new Vector2(-0.15f, 1.64f);
        hair_styles_vector[3] = new Vector2(-0.08f, 1.62f);
        hair_styles_vector[4] = new Vector2(-0.36f, 0.73f);


        hair_scales_vector = new Vector2[5];
        hair_scales_vector[0] = new Vector2(-1.5f, 1.4f);
        hair_scales_vector[1] = new Vector2(-1.5f, 1.4f);
        hair_scales_vector[2] = new Vector2(-1.5f, 1.4f);
        hair_scales_vector[3] = new Vector2(-1.5f, 1.4f);
        hair_scales_vector[4] = new Vector2(-1.5f, 1.5f);


        HairIndex = PlayerPrefs.GetInt("BoyHair", 0);
        //Hair


        //Shirt
        shirt_styles = new Sprite[2];
        shirt_styles[0] = Resources.Load<Sprite>("Boy/Special2/Shirt/shirt-1");
        shirt_styles[1] = Resources.Load<Sprite>("Boy/Special2/Shirt/shirt-2");



        shirt_styles_vector = new Vector2[2];
        shirt_styles_vector[1] = new Vector2(-1.04f, -13.53f);
        shirt_styles_vector[0] = new Vector2(42.56f, -7.87f);



        shirt_scales_vector = new Vector2[2];
        shirt_scales_vector[1] = new Vector2(1f, 1f);
        shirt_scales_vector[0] = new Vector2(1f, 1f);




        ShirtIndex = PlayerPrefs.GetInt("BoySpecial", 0);
        //Shirt



        //Skin
        colors = new Vector3[4];
        colors[0] = new Vector3(244f, 194f, 157f);
        colors[1] = new Vector3(242f, 178f, 126f);
        colors[2] = new Vector3(224f, 154f, 101f);
        colors[3] = new Vector3(168f, 106f, 64f);

        SkinIndex = PlayerPrefs.GetInt("BoyColor", 0);

        //Skin
    }
    void Start()
    {
        //init   
        girl_hair = girl_hair_obj.GetComponent<SpriteRenderer>();
        girl_shirt = girl_shirt_obj.GetComponent<SpriteRenderer>();
        skin = gameObject.GetComponent<SpriteRenderer>();
        //init

        //outfitload
        girl_hair.sprite = hair_styles[HairIndex];
        girl_hair_obj.transform.localPosition = hair_styles_vector[HairIndex];
        girl_hair_obj.transform.localScale = hair_scales_vector[HairIndex];

        girl_shirt.sprite = shirt_styles[ShirtIndex];
        girl_shirt_obj.transform.localPosition = shirt_styles_vector[ShirtIndex];
        girl_shirt_obj.transform.localScale = shirt_scales_vector[ShirtIndex];



        skin.color = new Color(colors[SkinIndex].x / 255f, colors[SkinIndex].y / 255f, colors[SkinIndex].z / 255f);



        //outfitload



    }
}

