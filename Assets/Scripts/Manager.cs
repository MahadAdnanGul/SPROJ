using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    int size;
    [SerializeField] GameObject[] Text_box;
    [SerializeField] float[] timed;
    
    // Start is called before the first frame update
    void Start()
    {
        size = Text_box.Length;
        for(int i=0;i<size;i++)
        {
            StartCoroutine(ExecuteAfterTime(timed[i], Text_box[i]));
        }
       
    }

    // Update is called once per frame
    

    IEnumerator ExecuteAfterTime(float time, GameObject text_b)
    {
        yield return new WaitForSeconds(time);

        text_b.SetActive(true);

        
    }
}
