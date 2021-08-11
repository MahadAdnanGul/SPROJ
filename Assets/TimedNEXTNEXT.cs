using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedNEXTNEXT : MonoBehaviour
{
    public float time;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(ExecuteAfterTime(time));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ExecuteAfterTime(float timed)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        gameObject.GetComponent<Exit>().NextNext();
    }
}

