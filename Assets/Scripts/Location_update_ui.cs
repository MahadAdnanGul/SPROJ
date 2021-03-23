using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Location_update_ui : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI loc_text;

    Dictionary<int, string> dict =new Dictionary<int,string>();
    
    // Start is called before the first frame update
    void Start()
    {
        dict.Add(2, "Backyard");
        dict.Add(3, "Sports Complex");
        dict.Add(4, "Sports Complex");
        dict.Add(5, "SDSB");
        dict.Add(6, "Masjid");
        dict.Add(7, "Library");
        dict.Add(8, "Law School");
        dict.Add(9, "Academic Block");
        dict.Add(10, "SSE");
        dict.Add(11, "REDC");
        dict.Add(12, "PDC");

    }

    // Update is called once per frame
    void Update()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        loc_text.text = dict[y];
    }
}
