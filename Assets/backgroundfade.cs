using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundfade : MonoBehaviour
{
    public Animator anim;
    public float time;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteAfter(time));
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    IEnumerator ExecuteAfter(float timed)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        anim.SetBool("active", true);
        
    }
}
