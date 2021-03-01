using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj_toggle : MonoBehaviour
{
    public Animator anim;
    
    public AudioClip button;
    bool toggle_state = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        anim.SetBool("button", toggle_state);
        
    }
    public void button_click()
    {
        if(toggle_state==false)
        {
            AudioSource.PlayClipAtPoint(button,transform.position);
            gameObject.SetActive(true);
            toggle_state = true;
           // GetComponent<Animation>().["Objective_popup"].wrapMode = WrapMode.Once;
           // GetComponent<Animation>().Play("Objective_popup");
        }
        else
        {
            AudioSource.PlayClipAtPoint(button, transform.position);
            //gameObject.SetActive(false);
            toggle_state = false;
        }
    }
}
