using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BROKEN : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void gone(int choice, float time )
    {
        StartCoroutine(ExecuteAfterTime(time, choice));
    }

    IEnumerator ExecuteAfterTime(float timed, int sc)
    {
        yield return new WaitForSeconds(timed);

        Debug.Log("Done");

        gameObject.GetComponent<Exit>().exiting(sc);
    }
}
