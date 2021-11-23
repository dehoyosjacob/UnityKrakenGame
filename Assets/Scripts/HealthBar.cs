using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider healthBar;
    [SerializeField] int maxHealth;
    [SerializeField] int currentHealth;
    [SerializeField] Text currentHealth_txt;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.minValue = 0;
    }

    public void TakeDamage(int damage)
    {
        if(currentHealth > 0)
        {
            currentHealth -= damage;
            currentHealth_txt.text = currentHealth.ToString();
            healthBar.value = currentHealth;
        }
    }
}
