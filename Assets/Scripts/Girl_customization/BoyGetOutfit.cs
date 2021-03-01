

    // Update is called once per frameusing System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyGetOutfit : MonoBehaviour
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

    //Trousers
    SpriteRenderer girl_trouser;
    [SerializeField] GameObject girl_trouser_obj;
    Sprite[] trouser_styles;
    Vector2[] trouser_styles_vector;
    int TrouserIndex;
    //Trousers

    //Shoes
    SpriteRenderer girl_shoes;
    [SerializeField] GameObject girl_shoes_obj;
    Sprite[] shoes_styles;
    Vector2[] shoes_styles_vector;
    int ShoesIndex;
    //Shoes

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
        hair_styles[0] = Resources.Load<Sprite>("Boy/SideProfile/Hair/hair-1");
        hair_styles[1] = Resources.Load<Sprite>("Boy/SideProfile/Hair/hair-2");
        hair_styles[2] = Resources.Load<Sprite>("Boy/SideProfile/Hair/hair-3");
        hair_styles[3] = Resources.Load<Sprite>("Boy/SideProfile/Hair/hair-4");
        hair_styles[4] = Resources.Load<Sprite>("Boy/SideProfile/Hair/hair-5");

        hair_styles_vector = new Vector2[5];
        hair_styles_vector[0] = new Vector2(0.141f, 6.583f);
        hair_styles_vector[1] = new Vector2(0.017f, 7.257f);
        hair_styles_vector[2] = new Vector2(0.03f, 7.231f);
        hair_styles_vector[3] = new Vector2(-0.035f, 7.146f);
        hair_styles_vector[4] = new Vector2(0.109f, 6.518f);

        HairIndex = PlayerPrefs.GetInt("BoyHair", 0);
        //Hair


        //Shirt
        shirt_styles = new Sprite[5];
        shirt_styles[0] = Resources.Load<Sprite>("Boy/SideProfile/Shirt/shirt-1");
        shirt_styles[1] = Resources.Load<Sprite>("Boy/SideProfile/Shirt/shirt-2");
        shirt_styles[2] = Resources.Load<Sprite>("Boy/SideProfile/Shirt/shirt-3");
        shirt_styles[3] = Resources.Load<Sprite>("Boy/SideProfile/Shirt/shirt-4");
        shirt_styles[4] = Resources.Load<Sprite>("Boy/SideProfile/Shirt/shirt-5");

        shirt_styles_vector = new Vector2[5];
        shirt_styles_vector[0] = new Vector2(-0.223f, 2.198f);
        shirt_styles_vector[1] = new Vector2(-0.223f, 2.198f);
        shirt_styles_vector[2] = new Vector2(-0.164f, 2.355f);
        shirt_styles_vector[3] = new Vector2(-0.042f, 2.482f);
        shirt_styles_vector[4] = new Vector2(-0.065f, 1.288f);

        ShirtIndex = PlayerPrefs.GetInt("BoyShirt", 0);
        //Shirt

        //Trouser
        trouser_styles = new Sprite[5];
        trouser_styles[0] = Resources.Load<Sprite>("Boy/SideProfile/Trouser/trouser-1");
        trouser_styles[1] = Resources.Load<Sprite>("Boy/SideProfile/Trouser/trouser-2");
        trouser_styles[2] = Resources.Load<Sprite>("Boy/SideProfile/Trouser/trouser-3");
        trouser_styles[3] = Resources.Load<Sprite>("Boy/SideProfile/Trouser/trouser-4");
        trouser_styles[4] = Resources.Load<Sprite>("Boy/SideProfile/Trouser/trouser-5");

        trouser_styles_vector = new Vector2[5];
        trouser_styles_vector[0] = new Vector2(-0.117f, -3.673f);
        trouser_styles_vector[1] = new Vector2(-0.19f, -3.53f);
        trouser_styles_vector[2] = new Vector2(-0.108f, -3.464f);
        trouser_styles_vector[3] = new Vector2(-0.018f, -1.728f);
        trouser_styles_vector[4] = new Vector2(-0.12f, -2.45f);

        TrouserIndex = PlayerPrefs.GetInt("BoyTrouser", 0);
        //Trouser

        //Shoes
        shoes_styles = new Sprite[4];
        shoes_styles[0] = Resources.Load<Sprite>("Boy/SideProfile/Shoes/shoes-1");
        shoes_styles[1] = Resources.Load<Sprite>("Boy/SideProfile/Shoes/shoes-2");
        shoes_styles[2] = Resources.Load<Sprite>("Boy/SideProfile/Shoes/shoes-3");
        shoes_styles[3] = Resources.Load<Sprite>("Boy/SideProfile/Shoes/shoes-4");

        shoes_styles_vector = new Vector2[4];
        shoes_styles_vector[0] = new Vector2(-0.121f, -7.436f);
        shoes_styles_vector[1] = new Vector2(-0.121f, -7.436f);
        shoes_styles_vector[2] = new Vector2(-0.159f, -7.436f);
        shoes_styles_vector[3] = new Vector2(-0.104f, -7.463f);

        ShoesIndex = PlayerPrefs.GetInt("BoyShoes", 0);
        //Shoes

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
        girl_trouser = girl_trouser_obj.GetComponent<SpriteRenderer>();
        girl_shoes = girl_shoes_obj.GetComponent<SpriteRenderer>();
        skin = gameObject.GetComponent<SpriteRenderer>();
        //init

        //outfitload
        girl_hair.sprite = hair_styles[HairIndex];
        girl_hair_obj.transform.localPosition = hair_styles_vector[HairIndex];

        girl_shirt.sprite = shirt_styles[ShirtIndex];
        girl_shirt_obj.transform.localPosition = shirt_styles_vector[ShirtIndex];

        girl_trouser.sprite = trouser_styles[TrouserIndex];
        girl_trouser_obj.transform.localPosition = trouser_styles_vector[TrouserIndex];

        girl_shoes.sprite = shoes_styles[ShoesIndex];
        girl_shoes_obj.transform.localPosition = shoes_styles_vector[ShoesIndex];

        skin.color = new Color(colors[SkinIndex].x / 255f, colors[SkinIndex].y / 255f, colors[SkinIndex].z / 255f);





        //outfitload



    }

    // Update is called once per frame
    
}


