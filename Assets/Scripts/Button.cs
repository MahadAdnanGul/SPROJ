using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    [SerializeField]
    TextMeshProUGUI Name;
    [SerializeField]
    TextMeshProUGUI Text;
    [SerializeField]
    Image box;

    //Resp1
    [SerializeField]
    Text Text_resp1;
    [SerializeField]
    Image button_resp1;

    //Resp2
    [SerializeField]
    Text Text_resp2;
    [SerializeField]
    Image button_resp2;

    //prev

    [SerializeField]
    TextMeshProUGUI init_Text;
    [SerializeField]
    Image init_box;


    bool default_state = false;
    public void Update()
    {
        anim.SetBool("switch", default_state);
    }

    public void Button_Press()
    {
        
            Name.enabled=true;
            Text.enabled = true;
            box.enabled = true;
            Text_resp1.enabled = true;
            button_resp1.enabled = true;
            Text_resp2.enabled = true;
            button_resp2.enabled = true;

            init_Text.enabled = false;
            init_box.enabled = false;
        default_state = true;
            


        
       

    }

}
