using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_move_law : MonoBehaviour
{
    GameObject suleman;
    GameObject player;
    float deadzone_s_p;
    float deadzone_s_n;

    float total_dist = (float)5.01 - (float)1.2;
    

    float deadzone_p_p;
    float deadzone_p_n;

    // Start is called before the first frame update
    void Start()
    {
        suleman = GameObject.FindGameObjectWithTag("sule2");
        player = GameObject.FindGameObjectWithTag("Player");
        deadzone_s_p = suleman.transform.position.x - ((float)5.01-Camera.main.transform.position.x ) / 8;
        deadzone_s_n = suleman.transform.position.x + (Camera.main.transform.position.x - (float)1.2) / 8;

        deadzone_p_p = player.transform.position.x - ((float)5.01 - Camera.main.transform.position.x) / 8;
        deadzone_p_n = player.transform.position.x + (Camera.main.transform.position.x - (float)1.2) / 8;
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

                Vector3 temp_Suleman = new Vector3(suleman.transform.position.x, suleman.transform.position.y, suleman.transform.position.z);
                temp_Suleman.x += (float)-0.25 * Time.deltaTime;
                suleman.transform.position = temp_Suleman;

                Vector3 temp_Player = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
                temp_Player.x += (float)-0.25 * Time.deltaTime;
                player.transform.position = temp_Player;
            }
            else if (inp < 0)
            {
                Vector3 temp = new Vector3(transform.position.x, transform.position.y, transform.position.z);
                temp.x += (float)-2 * Time.deltaTime;
                transform.position = temp;

                Vector3 temp_Suleman = new Vector3(suleman.transform.position.x, suleman.transform.position.y, suleman.transform.position.z);
                temp_Suleman.x += (float)0.25 * Time.deltaTime;
                suleman.transform.position = temp_Suleman;

                Vector3 temp_Player = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
                temp_Player.x += (float)0.25 * Time.deltaTime;
                player.transform.position = temp_Player;
            }

        }


        if (transform.position.x < 1.2)
        {
            Vector3 temp = new Vector3((float)1.2, transform.position.y, transform.position.z);
            transform.position = temp;

            Vector3 temp_Suleman = new Vector3(deadzone_s_n, suleman.transform.position.y, suleman.transform.position.z);
            suleman.transform.position = temp_Suleman;

            Vector3 temp_P = new Vector3(deadzone_p_n, player.transform.position.y, player.transform.position.z);
            player.transform.position = temp_P;
        }
        if (transform.position.x > 5.01)
        {
            Vector3 temp = new Vector3((float)5.01, transform.position.y, transform.position.z);
            transform.position = temp;

            Vector3 temp_Suleman = new Vector3(deadzone_s_p, suleman.transform.position.y, suleman.transform.position.z);
            suleman.transform.position = temp_Suleman;

            Vector3 temp_P = new Vector3(deadzone_p_p, player.transform.position.y, player.transform.position.z);
            player.transform.position = temp_P;
        }





    }
}
