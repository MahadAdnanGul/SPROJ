using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_move_acd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            float inp = Input.GetAxis("Horizontal");
            if (inp > 0)
            {
                Vector3 temp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                temp.x += (float)2 * Time.deltaTime;
                transform.position = temp;
            }
            else if (inp < 0)
            {
                Vector3 temp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                temp.x += (float)-2 * Time.deltaTime;
                transform.position = temp;
            }

        }
        if (transform.position.x < -2.5)
        {
            Vector3 temp = new Vector3((float)-2.5, transform.position.y, transform.position.z);
            transform.position = temp;
        }
        if (transform.position.x > 1.3)
        {
            Vector3 temp = new Vector3((float)1.3, transform.position.y, transform.position.z);
            transform.position = temp;
        }

    }
}
