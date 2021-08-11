using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectButtons : MonoBehaviour
{
    GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    public void Freshmen()
    {
        SceneManager.LoadScene("Charecter_select");
    }
    public void Soph()
    {
        gm.SophYear();
    }
    public void Junior()
    {
        gm.JuniorYear();
    }
    public void Senior()
    {
        gm.SeniorYear();
    }
}
