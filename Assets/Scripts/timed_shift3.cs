using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timed_shift3 : MonoBehaviour
{
    public Animator pop;
    public GameObject text_obj;
    // Start is called before the first frame update
    private void Awake()
    {
        
    }
    void Start()
    {
        text_obj = GameObject.FindGameObjectWithTag("MainCamera");
        StartCoroutine(ExecuteAfterTime());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(3);

        Debug.Log("Done");

        pop.SetBool("yes", true);
        yield return new WaitForSeconds(2);
        text_obj.GetComponent<PopupEnable>().Enabler();

    }
}
