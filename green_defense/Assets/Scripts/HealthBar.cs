using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image=UnityEngine.UI.Image;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private int hp;
    
    [SerializeField]
    private int hpmax;
    private Image healthbar;

    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
    }

    public void TakeDamage(int damages)
    {
        hp -= damages;
        UpdateHealth();
    }

    // Actualise les points de vie pour rester entre 0 et hpmax
    public void UpdateHealth()
    {
        hp = Mathf.Clamp(hp, 0, hpmax);
        float amount = (float)hp / hpmax;
        healthbar.fillAmount = amount;
    }
}
