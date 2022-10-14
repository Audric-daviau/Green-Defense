using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemFromDome : MonoBehaviour
{
    //Spawn this object
    public GameObject spawnObject;

    public float maxTime = 30;
    public float minTime = 15;
    private AudioSource _soundEffect;

    //current time
    private float time;

    //The time to spawn the object
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
        _soundEffect = spawnObject.GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }


    //Spawns the object and resets the time
    void SpawnObject()
    {
        time = 0;
        float x = Random.Range(1f, -8f);
        Vector3 position = transform.position + new Vector3(x, 2, 24);
        Instantiate(spawnObject, position, spawnObject.transform.rotation);
        _soundEffect.Play();
    }

    //Sets the random time between minTime and maxTime
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }


}
