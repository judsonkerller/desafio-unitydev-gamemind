using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    public float health = 15;
    public float Health
    {
        get 
        {
            return health;
        }
        set
        {
            health = Mathf.Clamp(value, 0, healthMax);
        }
    }
    public float healthMax = 15;

    public Image healthBar;

    private void Update()
    {
        //Inputs para verificar se o limite máximo colocado na barra de vida está funcionando
        /*if(Input.GetKey(KeyCode.UpArrow))
        {
            Health += 0.5f;
        }*/
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        healthBar.fillAmount = health / healthMax;
    }
}
