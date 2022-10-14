using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fromSeedToTree : MonoBehaviour
{
    public GameObject tree;
    private AudioSource _soundEffect;

    // Start is called before the first frame update
    void Start()
    {
        _soundEffect = tree.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Terrain"))
        {
            var t = GameObject.Instantiate(tree);
            t.transform.position = transform.position;
            _soundEffect.Play();
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Terrain"))
        {

        }
    }
}
