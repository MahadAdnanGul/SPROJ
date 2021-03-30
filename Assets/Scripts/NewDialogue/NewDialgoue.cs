using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewDialgoue : MonoBehaviour
{
    public float animSpeed = 0.05f;
    public TextMeshProUGUI message;
    public GameObject trigger;
    public string[] messageArr;
    private int maxCount;
    private int currentCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        maxCount = messageArr.Length;
        NextMessageOptionalReset();
    }

    public void NextMessageTrigger()
    {
        if(currentCount<maxCount)
        {
            StopAllCoroutines();
            message.text = messageArr[currentCount];
            string sentence = messageArr[currentCount];
            StartCoroutine(TypeSentence(sentence));
            currentCount++;
        }
        else
        {
            trigger.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }
    }
    
    public void NextMessageOptionalReset()
    {
        if (currentCount < maxCount)
        {
            StopAllCoroutines();
            message.text = messageArr[currentCount];
            string sentence = messageArr[currentCount];
            StartCoroutine(TypeSentence(sentence));
            currentCount++;
        }
        else
        {
            Debug.Log("ohno");
            gameObject.GetComponent<ResetDialogue>().Reset();
            gameObject.SetActive(false);
        }
    }


    public void ResetDialogues(string[] messages, GameObject newTrigger)
    {
        gameObject.SetActive(true);
        currentCount = 0;
        maxCount = messages.Length;
        messageArr = messages;
        trigger = newTrigger;
        NextMessageOptionalReset();
        
    }

    IEnumerator TypeSentence(string sentence)
    {
        message.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            message.text += letter;
            yield return new WaitForSeconds(animSpeed);
        }
    }

}
