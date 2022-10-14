using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeDamage : MonoBehaviour
{
    public HealthBar lifeBar;
    public GameObject seed;
    public bool isDestroy;
    bool _detectTrash;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(_detectTrash)
        {
            Debug.Log("Take dommage") ;
            lifeBar.TakeDamage() ;
        }

        if(lifeBar.getHp() == 0){
            float x = UnityEngine.Random.Range(0f, 3f);
            if(x != 0)
            {
                Instantiate(seed, this.transform.position + new Vector3(0,0.5f, 0), this.transform.rotation);
            }

            isDestroy = true;
            Destroy(this.gameObject);
            
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trash"))
        {
            _detectTrash = true;
        }
    }

}