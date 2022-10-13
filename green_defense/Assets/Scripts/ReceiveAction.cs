using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveAction : MonoBehaviour
{
    //Maximum de points de vie | A MODIFIER
    public int maxHitPoint = 20;
 
    //Points de vie actuels | A MODIFIER
    public int hitPoint = 0;
 
    private void Start()
    {
        //Au début : Points de vie actuels = Maximum de points de vie | NOMBRE DE GRAINES?
        hitPoint = maxHitPoint;
    }
 
 
    //Permet de recevoir des dommages
    public void GetDamage(int damage)
    {
        //Applique les dommages aux points de vies actuels
        hitPoint -= damage;
 
        //Si les point de vie sont inférieurs à 1 = Supprime l'objet
        if(hitPoint < 1)
        {
            Destroy(gameObject);
        }
    }
}
