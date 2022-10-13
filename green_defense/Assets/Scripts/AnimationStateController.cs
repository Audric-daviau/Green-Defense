using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    public HealthBar hb;

    private bool isTreeDetect;
    public float moveSpeed;
    Transform treeTransform;
    Animator animator;
    Rigidbody rb;
    int dommage = 10 ;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
        DetecteZone() ;
        if(hb.getHp() == 0){
            Destroy(this.gameObject);
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

    void DetecteZone() //Détecte si les personnages rentre dans la zone de converssion de l'arbre
    {
        bool isTree = animator.GetBool("isTree");
        if (isTreeDetect)
        {
            animator.SetBool("isTree", true);
            transform.position += transform.forward * 0 * Time.deltaTime;
            transform.LookAt(treeTransform);
            Debug.Log("dans la zone de détection") ;    
            hb.TakeDamage() ; //Inflige des dégats 

        }

        if (!isTreeDetect)
        {
            animator.SetBool("isTree", false);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

}
