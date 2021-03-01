using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.UIElements;
using UnityEngine.UI;
using Image = UnityEngine.UI.Image;
using Slider = UnityEngine.UI.Slider;

public class Objectives : MonoBehaviour
{
    //public Animator anim_button;
    [SerializeField]
    Slider completion_bar;
    [SerializeField]
    Image NEW;
    [SerializeField]
    TextMeshProUGUI obj_text;
    string[] obj = { "Talk to Roommate", "Exit to khoka","Talk to roommate","Interact with yourself","talk to roommate","Get ready","Exit to SSE","Acknowledge","Interact with yourself","na","na","na","na","na","na","na" };
    int current = 1;
    // Start is called before the first frame update
    void Start()
    {
        obj_text.text = obj[0];
    }

    // Update is called once per frame
    void Update()
    {
        //if(anim_button.GetBool("check")==true)
       // {
       //     anim_button.SetBool("check", false);
       // }

    }
    public void change_obj()
    {
        //anim_button.SetBool("check", false);

        obj_text.text = obj[current];
        current++;
        completion_bar.value++;
        //anim_button.SetBool("check", true);
        gameObject.GetComponent<Animator>().Play("base Layer.objective_comp");
        NEW.gameObject.SetActive(true);        
    }
}
