using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlGetOutfitSittingHalf : MonoBehaviour
{
    //Hair
    SpriteRenderer girl_hair;
    [SerializeField] GameObject girl_hair_obj;
    Sprite[] hair_styles;
    Vector2[] hair_styles_vector;
    int HairIndex;
    //Hair

    //Shirt
    SpriteRenderer girl_shirt;
    [SerializeField] GameObject girl_shirt_obj;
    Sprite[] shirt_styles;
    Vector2[] shirt_styles_vector;
    int ShirtIndex;
    //Shirt


    //Skin
    SpriteRenderer skin;
    Vector3[] colors;
    int SkinIndex;
    //Skin

    //Hand

    // Start is called before the first frame update


    private void Awake()
    {
        //Hair
        hair_styles = new Sprite[4];
        hair_styles[0] = Resources.Load<Sprite>("Girl/SittingClassroom/Hair/hairsit-1");
        hair_styles[1] = Resources.Load<Sprite>("Girl/SittingClassroom/Hair/hairsit-2");
        hair_styles[2] = Resources.Load<Sprite>("Girl/SittingClassroom/Hair/hairsit-3");
        hair_styles[3] = Resources.Load<Sprite>("Girl/SittingClassroom/Hair/hairsit-4");

        hair_styles_vector = new Vector2[4];
        hair_styles_vector[0] = new Vector2(-0.24f, 2.06f);
        hair_styles_vector[1] = new Vector2(-0.211f, 1.683f);
        hair_styles_vector[2] = new Vector2(0f, 1.07f);
        hair_styles_vector[3] = new Vector2(-0.03f, 1.3f);

        HairIndex = PlayerPrefs.GetInt("GirlHair", 0);
        //Hair


        //Shirt
        shirt_styles = new Sprite[4];
        shirt_styles[0] = Resources.Load<Sprite>("Girl/SittingClassroom/Shirt/shirtsit-1");
        shirt_styles[1] = Resources.Load<Sprite>("Girl/SittingClassroom/Shirt/shirtsit-2");
        shirt_styles[2] = Resources.Load<Sprite>("Girl/SittingClassroom/Shirt/shirtsit-3");
        shirt_styles[3] = Resources.Load<Sprite>("Girl/SittingClassroom/Shirt/shirtsit-4");

        shirt_styles_vector = new Vector2[4];
        shirt_styles_vector[0] = new Vector2(-0.121f, -0.975f);
        shirt_styles_vector[1] = new Vector2(-0.121f, -0.975f);
        shirt_styles_vector[2] = new Vector2(-0.121f, -0.975f);
        shirt_styles_vector[3] = new Vector2(-0.121f, -0.975f);

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
        girl_hair = girl_hair_obj.GetComponent<SpriteRenderer>();
        girl_shirt = girl_shirt_obj.GetComponent<SpriteRenderer>();
     
        skin = gameObject.GetComponent<SpriteRenderer>();
        //init

        //outfitload
        girl_hair.sprite = hair_styles[HairIndex];
        girl_hair_obj.transform.localPosition = hair_styles_vector[HairIndex];

        girl_shirt.sprite = shirt_styles[ShirtIndex];
        girl_shirt_obj.transform.localPosition = shirt_styles_vector[ShirtIndex];

       

        skin.color = new Color(colors[SkinIndex].x / 255f, colors[SkinIndex].y / 255f, colors[SkinIndex].z / 255f);
        





        //outfitload



    }

    // Update is called once per frame
    void Update()
    {

    }
}
