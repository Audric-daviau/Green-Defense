using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image=UnityEngine.UI.Image;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private int _hp = 50;
    
    [SerializeField]
    private int _hpmax = 50;
    private Image healthbar;

    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
    }

    public void TakeDamage(int damages)
    {
        _hp -= damages;
        UpdateHealth();
    }

    // Actualise les points de vie pour rester entre 0 et _hpmax
    public void UpdateHealth()
    {
        _hp = Mathf.Clamp(_hp, 0, _hpmax);
        float amount = (float)_hp / _hpmax;
        healthbar.fillAmount = amount;
    }
}
