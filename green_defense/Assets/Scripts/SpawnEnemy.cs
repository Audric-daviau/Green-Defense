using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    //public GameObject PeoplePrefab;
    public GameObject[] PeopleList;
    public int nbMaxPeople;
    public int nbMinPeople;

    public Transform center;
    public Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        int rnd = Random.Range(nbMinPeople, nbMaxPeople);
        for (int i = 0; i < rnd; i++)
        {
            SpawnPeople();
        }

    }

    public void SpawnPeople()
    {
        int whichItem = Random.Range(0, 4);
        Vector3 pos = center.position + new Vector3(Random.Range(-size.x / 2, size.x / 2), 1f, Random.Range(-size.z / 2, size.z / 2));
        Instantiate(PeopleList[whichItem], pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center.position, size);
    }
}
