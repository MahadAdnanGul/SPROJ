using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    int money = 0;
    [SerializeField]
    TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "0";
    }

    // Update is called once per frame
    public void add_money()
    {
        money += 20;
        score.text = money.ToString();
    }
    public void deduct_money(int amount)
    {
        money -= amount;
        score.text = money.ToString();
    }

}
