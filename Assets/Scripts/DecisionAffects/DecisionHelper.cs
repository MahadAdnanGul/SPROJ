using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionHelper : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setloweek(bool val)
    {
        FindObjectOfType<GameManager>().lunch_with_oweekFriend = val;
    }
    public void Setlfriend(bool val)
    {
        FindObjectOfType<GameManager>().lunch_with_friends = val;
    }
    public void SetColor(string val)
    {
        FindObjectOfType<GameManager>().cDay = val;
    }


    // Update is called once per frame

}
