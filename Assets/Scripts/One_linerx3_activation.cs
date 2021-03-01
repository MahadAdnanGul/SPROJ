using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_linerx3_activation : MonoBehaviour
{
    public GameObject text_box;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(count>=3)
        {
            text_box.SetActive(true);
        }
    }
   public void increase_count()
    {
        count++;
    }
}
