using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Done : MonoBehaviour
{
    // Start is called before the first frame update
    


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


    //talk
    //[SerializeField]
    //TextMeshProUGUI T_Text_resp1;
    //[SerializeField]
    //Image T_button;

    //done




    public void Button_Press()
    {


        P_Name.enabled = false;
        P_Text.enabled = false;
        P_box.enabled = false;
        P_Text_resp1.enabled = false;
        P_button_resp1.enabled = false;

      //  T_Text_resp1.enabled = true;
    // T_button.enabled = true;











    }

}


