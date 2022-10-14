using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeDamage : MonoBehaviour
{
    public HealthBar lifeBar;

    bool _detectTrash;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(lifeBar.getHp() == 0){
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            lifeBar.TakeDamage() ;
            Debug.Log("Trash detect, getHp() = " + lifeBar.getHp()) ;
            _detectTrash = true;
        }
    }

}
