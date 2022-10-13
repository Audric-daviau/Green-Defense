using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seedPicker : MonoBehaviour
{
    GameObject objectseed;
    int sac;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Seed"))
        {
            sac++;
            Debug.Log("j'ai le seed " + sac);
            Destroy(other.gameObject);
        }
    }
}
