using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVida : MonoBehaviour
{

	public int maxHealth = 10;
	public int currentHealth;

    public BarraVida healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
        	TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
    	currentHealth -= damage;
    	healthBar.SetHealth(currentHealth);
    }
}
