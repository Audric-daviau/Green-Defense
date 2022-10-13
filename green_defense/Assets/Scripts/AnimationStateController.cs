using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    private bool isTreeDetect;
    public float moveSpeed;
    Transform treeTransform;
    Animator animator;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        bool isTree = animator.GetBool("isTree");
        if (isTreeDetect)
        {
            animator.SetBool("isTree", true);
            transform.position += transform.forward * 0 * Time.deltaTime;
            /*Vector3 direction = treeTransform.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
            transform.rotation = rotation;*/
            transform.LookAt(treeTransform);

        }

        if (!isTreeDetect)
        {
            animator.SetBool("isTree", false);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Tree")){
            isTreeDetect = true;
            treeTransform = other.transform;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tree")){
            isTreeDetect = false;
        }
    }
}
