using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoneDamageTree : MonoBehaviour
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
            Debug.Log("un enemy !");
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
