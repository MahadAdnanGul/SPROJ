using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enabler : MonoBehaviour
{
    public GameObject x;
    // Start is called before the first frame update
    public void ObjectEnable()
    {
        x.SetActive(true);
    }
}
