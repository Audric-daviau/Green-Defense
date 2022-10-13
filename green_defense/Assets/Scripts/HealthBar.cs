using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Image=UnityEngine.UI.Image;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private float _hp = 50;
    private float _hpmax = 50;
    private Image healthbar;

    float coef = 5.0f;

    public float getHp()
    {
        return _hp;
    }

    public void setCurrentHP(float hp)
    {
        _hp = hp;
    }

    // Start is called before the first frame update
    void Start()
    {
        healthbar = GetComponent<Image>();
    }

    public void TakeDamage()
    {
        _hp -= coef * Time.deltaTime ;
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
