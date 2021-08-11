using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyFarewell : MonoBehaviour
{
    public void Suit()
    {
        PlayerPrefs.SetInt("BoySpecial", 0);
    }
    public void SK()
    {
        PlayerPrefs.SetInt("BoySpecial", 1);
    }
    public void SKGirl()
    {
        PlayerPrefs.SetInt("GirlSpecial", 2);
    }
    public void Sari()
    {
        PlayerPrefs.SetInt("GirlSpecial", 1);
    }
}
