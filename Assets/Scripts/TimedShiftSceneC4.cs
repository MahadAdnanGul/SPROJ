using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedShiftSceneC4 : MonoBehaviour
{
    public GameObject board;
    // Start is called before the first frame update
    void Start()
    {
        board = GameObject.FindGameObjectWithTag("TextPop");
        StartCoroutine(ExecuteAfterTime());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ExecuteAfterTime()
    {
        yield return new WaitForSeconds(4);

        Debug.Log("Done");

        gameObject.SetActive(false);
        board.GetComponent<PopupEnable>().Enabler();
    }
}
