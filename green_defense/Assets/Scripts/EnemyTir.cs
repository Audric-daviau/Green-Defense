using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTir : MonoBehaviour
{
    public Transform spawnBullet;
    public GameObject bullet;
    Animator animator;
    public float shootSpeed = 30f;
    public float timeToShoot = 5f;
    float originalTime;

    void Start()
    {
        animator = GetComponent<Animator>();
        originalTime = timeToShoot;
    }

    private void FixedUpdate()
    {
        bool isTree = animator.GetBool("isTree");
        if (isTree)
        {
            timeToShoot -= Time.deltaTime;

            if (timeToShoot < 0)
            {
                shootBullet();
                timeToShoot = originalTime;

            }
        }
        
    }

    void shootBullet()
    {
        GameObject currentBullet = Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
        Rigidbody rig = currentBullet.GetComponent<Rigidbody>();

        rig.AddForce(transform.forward * shootSpeed, ForceMode.VelocityChange);
        Destroy(currentBullet, 2f);
    }
}
