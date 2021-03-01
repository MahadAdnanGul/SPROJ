using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlGetOutfitBack : MonoBehaviour
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
        hair_styles = new Sprite[4];
        hair_styles[0] = Resources.Load<Sprite>("Girl/Back/Hair/hairback-1");
        hair_styles[1] = Resources.Load<Sprite>("Girl/Back/Hair/hairback-2");
        hair_styles[2] = Resources.Load<Sprite>("Girl/Back/Hair/hairback-3");
        hair_styles[3] = Resources.Load<Sprite>("Girl/Back/Hair/hairback-4");

        hair_styles_vector = new Vector2[4];
        hair_styles_vector[0] = new Vector2(-0.08f, 3.32f);
        hair_styles_vector[1] = new Vector2(-0.08f, 3.32f);
        hair_styles_vector[2] = new Vector2(-0.058f, 3.132f);
        hair_styles_vector[3] = new Vector2(-0.058f, 3.551f);

        HairIndex = PlayerPrefs.GetInt("GirlHair", 0);
        //Hair


        //Shirt
        shirt_styles = new Sprite[4];
        shirt_styles[0] = Resources.Load<Sprite>("Girl/Back/Shirt/shirtback-1");
        shirt_styles[1] = Resources.Load<Sprite>("Girl/Back/Shirt/shirtback-2");
        shirt_styles[2] = Resources.Load<Sprite>("Girl/Back/Shirt/shirtback-3");
        shirt_styles[3] = Resources.Load<Sprite>("Girl/Back/Shirt/shirtback-4");

        shirt_styles_vector = new Vector2[4];
        shirt_styles_vector[0] = new Vector2(-0.174f, 0.88f);
        shirt_styles_vector[1] = new Vector2(-0.158f, 0.715f);
        shirt_styles_vector[2] = new Vector2(-0.133f, 1.258f);
        shirt_styles_vector[3] = new Vector2(-0.157f, 1.307f);

        ShirtIndex = PlayerPrefs.GetInt("GirlShirt", 0);
        //Shirt

        //Trouser
        trouser_styles = new Sprite[4];
        trouser_styles[0] = Resources.Load<Sprite>("Girl/Back/Trouser/trouserback-1");
        trouser_styles[1] = Resources.Load<Sprite>("Girl/Back/Trouser/trouserback-2");
        trouser_styles[2] = Resources.Load<Sprite>("Girl/Back/Trouser/trouserback-3");
        trouser_styles[3] = Resources.Load<Sprite>("Girl/Back/Trouser/trouserback-4");

        trouser_styles_vector = new Vector2[4];
        trouser_styles_vector[0] = new Vector2(0.39f, -2.013f);
        trouser_styles_vector[1] = new Vector2(0.356f, -1.984f);
        trouser_styles_vector[2] = new Vector2(0.402f, -1.984f);
        trouser_styles_vector[3] = new Vector2(0.383f, -1.993f);

        TrouserIndex = PlayerPrefs.GetInt("GirlTrouser", 0);
        //Trouser

        //Shoes
        shoes_styles = new Sprite[4];
        shoes_styles[0] = Resources.Load<Sprite>("Girl/Back/Shoes/shoesback-1");
        shoes_styles[1] = Resources.Load<Sprite>("Girl/Back/Shoes/shoesback-2");
        shoes_styles[2] = Resources.Load<Sprite>("Girl/Back/Shoes/shoesback-3");
        shoes_styles[3] = Resources.Load<Sprite>("Girl/Back/Shoes/shoesback-4");

        shoes_styles_vector = new Vector2[4];
        shoes_styles_vector[0] = new Vector2(0.398f, -3.763f);
        shoes_styles_vector[1] = new Vector2(0.472f, -3.884f);
        shoes_styles_vector[2] = new Vector2(0.472f, -3.884f);
        shoes_styles_vector[3] = new Vector2(0.416f, -3.538f);

        ShoesIndex = PlayerPrefs.GetInt("GirlShoes", 0);
        //Shoes

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
    void Update()
    {

    }
}
