using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Slider completionBar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnLevelWasLoaded(int level)
    {
        completionBar.value = SceneManager.GetActiveScene().buildIndex;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
