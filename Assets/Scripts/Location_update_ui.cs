using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Location_update_ui : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI loc_text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int y = SceneManager.GetActiveScene().buildIndex;
        if (y == 0 || y== 6)
            loc_text.text = "Hostel Room";
        else if (y == 1 || y==2|| y==3||y==4||y==5)
            loc_text.text = "Khoka";
        else 
            loc_text.text = "Outside SSE";
    }
}
