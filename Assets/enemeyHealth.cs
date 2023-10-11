using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemeyHealth : MonoBehaviour
{

    Slider healthBar;
    Enemy_Data playerHealth;

    private void Start()
    {
        healthBar = GetComponent<Slider>();
        playerHealth = GameObject.FindAnyObjectByType<Enemy_Data>();
        healthBar.maxValue = playerHealth.maxHealth;
        healthBar.value = playerHealth.Health;

    }
    private void Update()
    {
        SetHealth(playerHealth.Health);
    }
    public void SetHealth(float hp)
    {
        healthBar.value = hp;
    }

}
