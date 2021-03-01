using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Button_ext : MonoBehaviour
{
    //public Animator anim;
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

    //Prev
    [SerializeField]
    TextMeshProUGUI P_Name;
    [SerializeField]
    TextMeshProUGUI P_Text;
    [SerializeField]
    Image P_box;

    //Resp1
    [SerializeField]
    Text P_Text_resp1;
    [SerializeField]
    Image P_button_resp1;

    //Resp2
    [SerializeField]
    Text P_Text_resp2;
    [SerializeField]
    Image P_button_resp2;

    //done
    bool default_state = false;


    public void Update()
    {
       // anim.SetBool("switch", default_state);
    }

    public void Button_Press()
    {


            P_Name.enabled = false;
            P_Text.enabled = false;
            P_box.enabled = false;
            P_Text_resp1.enabled = false;
            P_button_resp1.enabled = false;
            P_Text_resp2.enabled = false;
            P_button_resp2.enabled = false;


            Name.enabled = true;
            Text.enabled = true;
            box.enabled = true;
            Text_resp1.enabled = true;
            button_resp1.enabled = true;
            Text_resp2.enabled = true;
            button_resp2.enabled = true;
        default_state = true;








    }

}
