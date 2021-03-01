using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class anim_active : MonoBehaviour

{
    [SerializeField]
    Animator anim;
    [SerializeField]
    GameObject story;
    [SerializeField]
    GameObject ready;
    [SerializeField]
    GameObject exit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void go()
    {

        story.SetActive(true);
        StartCoroutine(ExecuteAfter(2));
        StartCoroutine(ExecuteAfter1(3));
        





    }

    IEnumerator ExecuteAfter(float timed)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        anim.SetBool("active", true);

       

    }
    IEnumerator ExecuteAfter1(float timed)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        story.SetActive(false);

        ready.SetActive(false);

        exit.SetActive(true);


;        

        

    }
}
