using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    public HealthBar hb;
    private GameObject tds;
    private bool isDestroyed;
    private bool isTreeDetect;
    private bool isPlayer;
    public float moveSpeed;
    Transform treeTransform;
    Transform person;
    Animator animator;
    Rigidbody rb;

    private int nbr_convert = 0;

    public bool getIsPlayer()
    {
        return isPlayer;
    }

    public int getNrb_convert()
    {
        return nbr_convert;
    }

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
            nbr_convert++;
            Destroy(this.gameObject);
        }
        if (tds.GetComponent<treeDamage>().isDestroy)
        {
            isTreeDetect = false;
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            isPlayer = true;
            person = other.transform;
        }

        else if (other.CompareTag("Tree")){
            isTreeDetect = true;
            treeTransform = other.transform;
            tds = other.gameObject;
        }
        
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Tree"))
        {
            isTreeDetect = false;
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

        else if (other.CompareTag("Player"))
        {
            isPlayer = false;
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

    }

    void DetecteZone() //Détecte si les personnages rentre dans la zone de converssion de l'arbre
    {
        bool isTree = animator.GetBool("isTree");
        if (isPlayer)
        {
            animator.SetBool("isTree", true);
            transform.position += transform.forward * 0 * Time.deltaTime;
            transform.LookAt(person);
            if (isTreeDetect)
            {
                hb.TakeDamage(); //Inflige des dégats
            }
        }
        else if (isTreeDetect)
        {
            animator.SetBool("isTree", true);
            transform.position += transform.forward * 0 * Time.deltaTime;
            transform.LookAt(treeTransform);
            Debug.Log("dans la zone de détection") ;    
            hb.TakeDamage() ; //Inflige des dégats

        }
        else
        {
            isTreeDetect = false;
            animator.SetBool("isTree", false);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }

            
        
    }

}
