using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Charecter_sprite : MonoBehaviour
{
    [SerializeField] GameObject Boy;
    [SerializeField] GameObject Girl;
    [SerializeField] Vector2 Position;
    [SerializeField] Vector2 BoyScale;
    [SerializeField] Vector2 GirlScale;

     GameObject Charecter;
    //bool boy;

    // Start is called before the first frame update
   
    private void Awake()
    {
        if(SceneManager.GetActiveScene().buildIndex==0)
        {

        }
        else
        {
            if (PlayerPrefs.GetString("boy", "False") == "True")
            {
                Charecter=Instantiate<GameObject>(Boy);
                Charecter.transform.position = Position;
                Charecter.transform.localScale = BoyScale;
            }
            else
            {
                  Charecter=Instantiate<GameObject>(Girl);
                  Charecter.transform.position = Position;
                Charecter.transform.localScale = GirlScale;
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Set_boy(bool value)
    {
        if(value==true)
            PlayerPrefs.SetString("boy", "True");
        else
            PlayerPrefs.SetString("boy", "False");

    }
    
}
