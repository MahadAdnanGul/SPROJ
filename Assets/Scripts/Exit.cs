
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    bool used = false;
    bool used2 = false;
    // Start is called before the first frame update
    public void exiting(int choice)
    {
        
            
            SceneManager.LoadScene(choice);
        
        
    

    }
    public void delay_exiting(int choices,float time)
    {


        StartCoroutine(ExecuteAfterTime(time, choices));




    }
    public void obj_changeD()
    {


        FindObjectOfType<Objectives>().change_obj();
    } 

        
    public void obj_change()
    {
        if(used==false)
        {
            FindObjectOfType<Objectives>().change_obj();
            used = true;

        }
        
    }
    public void obj_change2()
    {
        if (used2 == false)
        {
            FindObjectOfType<Objectives>().change_obj();
            used2 = true;

        }
    }


    IEnumerator ExecuteAfterTime(float timed, int sc)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        exiting(sc);
    }
}
