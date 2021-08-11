using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScreen : MonoBehaviour
{
    GameManager gm;
    [SerializeField ]GameObject Default;
    [SerializeField] GameObject Soph;
    [SerializeField] GameObject Junior;
    [SerializeField] GameObject Senior;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
        if(PlayerPrefs.GetString("Senior","False")=="True")
        {
            Senior.SetActive(true);
        }
        else if (PlayerPrefs.GetString("Junior", "False") == "True")
        {
            Junior.SetActive(true);
        }
        else if (PlayerPrefs.GetString("Soph", "False") == "True")
        {
            Soph.SetActive(true);
        }
        else
        {
            Default.SetActive(true);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
