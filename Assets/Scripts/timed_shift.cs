using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timed_shift : MonoBehaviour
{
    public float time;
    public int scene_n;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ExecuteAfterTime(time,scene_n));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ExecuteAfterTime(float timed,int sc)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        gameObject.GetComponent<Exit>().exiting(sc);
    }
}
