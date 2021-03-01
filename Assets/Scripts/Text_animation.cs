using Boo.Lang.Environments;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Text_animation : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI Dialogue;
    [SerializeField]
    AudioSource my_fx;
    
    // Start is called before the first frame update
    public void text_anim()
    {
        my_fx.Play();
        string sentence = Dialogue.text;
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }
    IEnumerator TypeSentence(string sentence)
    {
        Dialogue.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            Dialogue.text += letter;
            yield return null;
        }
    }
}
