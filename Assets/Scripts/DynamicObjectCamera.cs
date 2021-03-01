using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObjectCamera : MonoBehaviour
{
    [SerializeField]
    float camera_max;
    [SerializeField]
    float camera_min;
    [SerializeField]
    float camera_current;

    [SerializeField] GameObject[] dynamicObj;
    [SerializeField] int[] moveFactor;

    float[] deadZonesP;
    float[] deadZonesN;
    bool forward;
    bool reverse;


    float distance_p;
    float distance_n;


    // GameObject suleman;
   // GameObject player;
    // float deadzone_s_p;
    //float deadzone_s_n;

   // float deadzone_p_p;
    //float deadzone_p_n;

    // Start is called before the first frame update
    void Start()
    {
        forward = true;
        reverse = true;
        deadZonesP = new float[dynamicObj.Length];
        deadZonesN = new float[dynamicObj.Length];
        distance_p = camera_max - camera_current;
        distance_n = camera_current - camera_min;

        for(int i =0;i<dynamicObj.Length;i++)
        {
            deadZonesP[i] = dynamicObj[i].transform.position.x - distance_p / moveFactor[i];
            deadZonesN[i] = dynamicObj[i].transform.position.x + distance_p / moveFactor[i];
        }


        //suleman = GameObject.FindGameObjectWithTag("Suleman");
       // player = GameObject.FindGameObjectWithTag("Player");
        //deadzone_s_p = suleman.transform.position.x -distance_p/8;
        //deadzone_s_n = suleman.transform.position.x + distance_n / 8;

       // deadzone_p_p = player.transform.position.x - distance_p / 8;
       // deadzone_p_n = player.transform.position.x + distance_n / 8;
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

                if(forward)
                {
                    for (int i = 0; i < dynamicObj.Length; i++)
                    {
                        Vector3 tempPos = new Vector3(dynamicObj[i].transform.position.x, dynamicObj[i].transform.position.y, dynamicObj[i].transform.position.z);
                        tempPos.x += ((float)1/(float)-moveFactor[i]) * Time.deltaTime;
                        dynamicObj[i].transform.position = tempPos;

                    }
                }
              

                // Vector3 temp_Suleman = new Vector3(suleman.transform.position.x, suleman.transform.position.y, suleman.transform.position.z);
                // temp_Suleman.x += (float)-0.25 * Time.deltaTime;
                // suleman.transform.position = temp_Suleman;

               // Vector3 temp_Player = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
               // temp_Player.x += (float)-0.25 * Time.deltaTime;
               // player.transform.position = temp_Player;
            }
            else if (inp < 0)
            {
                Vector3 temp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                temp.x += (float)-2 * Time.deltaTime;
                transform.position = temp;

                if(reverse)
                {
                    for (int i = 0; i < dynamicObj.Length; i++)
                    {
                        Vector3 tempPos = new Vector3(dynamicObj[i].transform.position.x, dynamicObj[i].transform.position.y, dynamicObj[i].transform.position.z);
                        tempPos.x += ((float)1/(float)moveFactor[i]) * Time.deltaTime;
                        dynamicObj[i].transform.position = tempPos;

                    }
                }
                

                // Vector3 temp_Suleman = new Vector3(suleman.transform.position.x, suleman.transform.position.y, suleman.transform.position.z);
                // temp_Suleman.x += (float)0.25 * Time.deltaTime;
                // suleman.transform.position = temp_Suleman;

                // Vector3 temp_Player = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
                // temp_Player.x += (float)0.25 * Time.deltaTime;
                // player.transform.position = temp_Player;
            }

        }


        if (transform.position.x < camera_min)
        {
            reverse = false;
            Vector3 temp = new Vector3(camera_min, transform.position.y, transform.position.z);
            transform.position = temp;

            //Vector3 temp_Suleman = new Vector3(deadzone_s_n, suleman.transform.position.y, suleman.transform.position.z);
            //suleman.transform.position = temp_Suleman;

            //Vector3 temp_P = new Vector3(deadzone_p_n, player.transform.position.y, player.transform.position.z);
            //player.transform.position = temp_P;
        }
        else
        {
            reverse = true;
        }
        if (transform.position.x > camera_max)
        {
            forward = false;
            Vector3 temp = new Vector3((float)camera_max, transform.position.y, transform.position.z);
            transform.position = temp;

            // Vector3 temp_Suleman = new Vector3(deadzone_s_p, suleman.transform.position.y, suleman.transform.position.z);
            //suleman.transform.position = temp_Suleman;

           // Vector3 temp_P = new Vector3(deadzone_p_p, player.transform.position.y, player.transform.position.z);
            //player.transform.position = temp_P;
        }
        else
        {
            forward = true;
        }





    }
}
