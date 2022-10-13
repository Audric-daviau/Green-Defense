using UnityEngine;
using TMPro;

public class Script_arbres_actifs : MonoBehaviour
{
    public GameObject[] liste_arbres_actif;
    public TextMeshProUGUI self;

    int Arbre_vivant()
    {

        liste_arbres_actif = GameObject.FindGameObjectsWithTag("Tree");
        return liste_arbres_actif.Length;
    }
    // Update is called once per frame
    void Update()
    {
        int nbr_abr = Arbre_vivant();
        self.text = (nbr_abr == 1) ? "Arbre Vivant: " + nbr_abr : "Arbres Vivants: " + nbr_abr;

    }
}