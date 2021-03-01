using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guy : MonoBehaviour
{
    [SerializeField]
    GameObject prefab_dollar;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void spawn_dollars()
    {
        int amount = Random.Range(1, 3);
        for (int x = 0; x <= amount; x++)
        {
            GameObject dollar = Instantiate(prefab_dollar) as GameObject;
            dollar.transform.position = transform.position;
        }
    }
    public void donate(int amount)
    {
        FindObjectOfType<Score>().deduct_money(amount);
        
    }
    public void obj_change()
    {
        FindObjectOfType<Objectives>().change_obj();
    }



}
