using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecisionBox : MonoBehaviour
{
    private GameManager gm;
    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }
    // Start is called before the first frame update
    public void DecisionData(Text text)
    {
        string ch = gm.chapterText.text[gm.chapterText.text.Length - 1].ToString();
        Debug.Log(gm);
        FindObjectOfType<InputHandler>().AddNameToList(Type.Choice, gm.year, int.Parse(ch), text.text);
    }
}
