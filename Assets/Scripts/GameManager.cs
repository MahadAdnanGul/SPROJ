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
    private int[] sliderVals = { 10, 10, 10, 10, 10, 10 };
    public TextMeshProUGUI chapterText;
    public bool lunch_with_oweekFriend;
    public bool lunch_with_friends;
    public string colorDay;
    public Sprite[] pdcSprite = new Sprite[3];
    public int year = 1;
    // Start is called before the first frame update

    public bool loweek
    {
        get { return lunch_with_oweekFriend; }
        set { lunch_with_oweekFriend = value; }
    }
    public string cDay
    {
        get { return colorDay; }
        set { colorDay = value; }
    }
    public bool lfriends
    {
        get { return lunch_with_friends; }
        set { lunch_with_friends = value; }
    }
    void Start()
    {
        UpdateLevel();
        
    }
    private void FixedUpdate()
    {
        UpdateChapter();
    }

    public void PDC(SpriteRenderer target)
    {
        if(lunch_with_friends==true)
        {
            target.sprite = pdcSprite[0];
        }
        else if(lunch_with_oweekFriend==true)
        {
            target.sprite = pdcSprite[1];
        }
        else
        {
            target.sprite = pdcSprite[2];
        }
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
    public void UpdateChapter()
    {
        if (SceneManager.GetActiveScene().buildIndex < 15)
            chapterText.text = "Chapter 1";
        else if (SceneManager.GetActiveScene().buildIndex < 20)
            chapterText.text = "Chapter 2";
        else if (SceneManager.GetActiveScene().buildIndex < 26)
            chapterText.text = "Chapter 3";
        else if (SceneManager.GetActiveScene().buildIndex < 32)
            chapterText.text = "Chapter 4";
        else if (SceneManager.GetActiveScene().buildIndex < 34)
            chapterText.text = "Chapter 5";
    }
}
