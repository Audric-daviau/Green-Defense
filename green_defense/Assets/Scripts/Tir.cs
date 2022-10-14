using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tir : MonoBehaviour
{
    public GameObject Projectil;
    public seedPicker sp;
    public int force = 50;
    private int nbSeeds;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseMenu.GameIsPaused && sp.sac != 0)
        {
            if(Input.GetButtonDown("Fire1")){
                GameObject Boule = Instantiate(Projectil, transform.position, Quaternion.identity) as GameObject;
                Boule.GetComponent<Rigidbody>().velocity= transform.TransformDirection(Vector3.forward * force);
                sp.sac--;
                Destroy(Boule, 2f);
            }   
        }

        
    }

}
