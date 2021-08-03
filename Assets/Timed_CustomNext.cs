using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timed_CustomNext : MonoBehaviour
{
    public float time;
    public string str;
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

        gameObject.GetComponent<Exit>().LoadCustom(str);
    }
}
