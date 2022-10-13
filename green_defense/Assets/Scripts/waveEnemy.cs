using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waveEnemy : MonoBehaviour
{
    public GameObject enemy;
    public float spawnTime = 3f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        var e = GameObject.Instantiate(enemy);
        e.transform.position = transform.position;
    }
}
