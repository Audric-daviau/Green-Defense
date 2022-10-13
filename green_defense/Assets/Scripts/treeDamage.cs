using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeDamage : MonoBehaviour
{
    bool isEnemy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEnemy)
        {
            //Todo
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            isEnemy = true;
        }
    }

}
