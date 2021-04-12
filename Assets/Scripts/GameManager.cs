using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject objButton;
    public Slider levelBar;
    public TextMeshProUGUI levelText;
    private int currentLevel;
    private int[] sliderVals = { 10, 10, 10, 10 };
    // Start is called before the first frame update
    void Start()
    {
        UpdateLevel();
    }

    public void IncreaseLevelProgress()
    {
        Debug.Log("Increase!");
        levelBar.value++;
        if(levelBar.value>=levelBar.maxValue)
        {
            LevelUp();
        }
    }
    // Update is called once per frame
    private void UpdateLevel()
    {
        currentLevel = PlayerPrefs.GetInt("Level", 1);
        levelText.text = "Level " + currentLevel.ToString();
        levelBar.maxValue = sliderVals[currentLevel - 1];
        levelBar.value = 0;
    }

    private void LevelUp()
    {
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level", 1)+1);
        UpdateLevel();
    }

    public void Next()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void EnterNameScene()
    {
        objButton.SetActive(false);
        SceneManager.LoadScene("EnterName");
    }
    public void CustomizeBoyScene()
    {
        objButton.SetActive(false);
        SceneManager.LoadScene("CustomizeBoy");
    }
    public void CustomizeGirlScene()
    {
        objButton.SetActive(false);
        SceneManager.LoadScene("CustomizeGirl");
    }
    public void StartGame()
    {
        objButton.SetActive(true);
        SceneManager.LoadScene("Start");
    }
}
