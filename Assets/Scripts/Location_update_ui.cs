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
        dict.Add(1, "loading...");
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
        dict.Add(13, "Dorm");
        dict.Add(14, "Loading...");
        dict.Add(15, "Outside SSE");
        dict.Add(16, "Outside SSE");
        dict.Add(17, "Loading...");
        dict.Add(18, "Classroom");
        dict.Add(19, "Classroom");
        dict.Add(20, "Classroom");
        dict.Add(21, "Dorm");
        dict.Add(22, "Loading...");
        dict.Add(23, "Khoka");
        dict.Add(24, "Khoka");
        dict.Add(25, "Khoka");
        dict.Add(26, "Khoka");
        dict.Add(27, "Customize");
        dict.Add(28, "Customize");
        dict.Add(30, "Customize");


    }

    // Update is called once per frame
    void Update()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        loc_text.text = dict[y];
    }
}
