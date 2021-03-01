using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class Heart: MonoBehaviour
{
    [SerializeField]
    AudioClip collect;
    // Start is called before the first frame update

    void Start()
    {
        float sign = Random.Range(-1, 1);
        if (sign >= 0)
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range((float)1.5, (float)3.0), Random.Range((float)1.5, (float)3.0)), ForceMode2D.Impulse);
        else
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(Random.Range((float)-1.5, (float)-3.0), Random.Range((float)1.5, (float)3.0)), ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        FindObjectOfType<Heart_score>().add_money();
        AudioSource.PlayClipAtPoint(collect, transform.position);
        Debug.Log("played");

        Destroy(gameObject);
    }

}
