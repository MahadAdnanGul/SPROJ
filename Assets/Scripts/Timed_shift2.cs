using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timed_shift2 : MonoBehaviour
{
    public GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteAfterTime());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(4);

        Debug.Log("Done");

        gameObject.SetActive(false);
        board.SetActive(true);
    }
}
