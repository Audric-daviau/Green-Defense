using UnityEngine;
using TMPro;

public class Script_Seed_Count : MonoBehaviour
{
    public TextMeshProUGUI self;
    public seedPicker sp;
    // Update is called once per frame
    void Update()
    {
        int nbr_seed = sp.sac;
        self.text = (nbr_seed <= 1) ? "Graine Restante: " + nbr_seed : "Graines Restantes: " + nbr_seed;
    }
}
