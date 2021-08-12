using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject topHud;
    public GameObject objButton;
    public Slider levelBar;
    public TextMeshProUGUI levelText;
    private int currentLevel;
    private int[] sliderVals = { 33, 10, 10, 10, 10, 10 };
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
        PlayerPrefs.SetInt("Scene", SceneManager.GetActiveScene().buildIndex);
        Debug.Log("Increase!");
        levelBar.value++;
        PlayerPrefs.SetFloat("Level", levelBar.value);
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
        
        topHud.SetActive(true);
        //objButton.SetActive(true);
        SceneManager.LoadScene("PreText");
    }
    public void DeletePrefs()
    {
        PlayerPrefs.DeleteAll();
    }
    public void Resume()
    {
        topHud.SetActive(true);
        SceneManager.LoadScene(PlayerPrefs.GetInt("Scene",0));
        levelBar.value = PlayerPrefs.GetFloat("Level", 0);
    }
    public void LEVEL_SELECT()
    {
        SceneManager.LoadScene("LevelSelect");
    }
    public void SophYear()
    {
        topHud.SetActive(true);
        SceneManager.LoadScene(39);
        levelBar.value = 9f;
    }
    public void JuniorYear()
    {
        topHud.SetActive(true);
        SceneManager.LoadScene(62);
        levelBar.value = 15f;
    }
    public void SeniorYear()
    {
        topHud.SetActive(true);
        SceneManager.LoadScene(85);
        levelBar.value = 23f;
    }
    public void UpdateChapter()
    {
        
        if (SceneManager.GetActiveScene().buildIndex < 21)
            chapterText.text = "Chapter 1";
        else if (SceneManager.GetActiveScene().buildIndex < 26)
            chapterText.text = "Chapter 2";
        else if (SceneManager.GetActiveScene().buildIndex < 32)
            chapterText.text = "Chapter 3";
        else if (SceneManager.GetActiveScene().buildIndex < 38)
            chapterText.text = "Chapter 4";
        else if (SceneManager.GetActiveScene().buildIndex < 40)
            chapterText.text = "Chapter 5";
        else if (SceneManager.GetActiveScene().buildIndex < 50)
        {
            chapterText.text = "Chapter 1";
            PlayerPrefs.SetString("Soph", "True");
        }
        else if (SceneManager.GetActiveScene().buildIndex < 55)
            chapterText.text = "Chapter 2";
        else if (SceneManager.GetActiveScene().buildIndex < 60)
            chapterText.text = "Chapter 3";
        else if (SceneManager.GetActiveScene().buildIndex < 62)
            chapterText.text = "Chapter 4";
        else if (SceneManager.GetActiveScene().buildIndex < 68)
        {
            chapterText.text = "Chapter 1";
            PlayerPrefs.SetString("Junior", "True");
        }
        else if (SceneManager.GetActiveScene().buildIndex < 71)
            chapterText.text = "Chapter 2";
        else if (SceneManager.GetActiveScene().buildIndex < 81)
            chapterText.text = "Chapter 3";
        else if (SceneManager.GetActiveScene().buildIndex < 83)
            chapterText.text = "Chapter 4";
        else if (SceneManager.GetActiveScene().buildIndex < 85)
            chapterText.text = "Chapter 5";
        else if (SceneManager.GetActiveScene().buildIndex < 88)
        {
            chapterText.text = "Chapter 1";
            PlayerPrefs.SetString("Senior", "True");
        }
        else if (SceneManager.GetActiveScene().buildIndex < 90)
            chapterText.text = "Chapter 2";
        else if (SceneManager.GetActiveScene().buildIndex < 93)
            chapterText.text = "Chapter 3";
        else if (SceneManager.GetActiveScene().buildIndex < 102)
            chapterText.text = "Chapter 4";
        else if (SceneManager.GetActiveScene().buildIndex >= 102)
            chapterText.text = "Chapter 5";

        PlayerPrefs.SetString("Chapter", chapterText.text);
    }
}
