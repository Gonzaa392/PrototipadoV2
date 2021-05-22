using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerVida : MonoBehaviour
{

	public int maxHealth = 10;
	public int currentHealth;

    public int maxEnergy = 10;
    public int currentEnergy;

    public BarraVida healthBar;
    public BarraEnergia energyBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
    }

    void SinVida(bool vida)
    {
    	if(maxHealth < 1)
    	{
    		SceneManager.LoadScene("Nivel 1 Prueba");
    	}

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
        	TakeDamage(1);
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            WasteEnergy(1);
        }
    }

    void TakeDamage(int damage)
    {
    	currentHealth -= damage;
    	healthBar.SetHealth(currentHealth);
    }

    void WasteEnergy(int waste)
    {
        currentEnergy -= waste;
        energyBar.SetEnergy(currentEnergy);
    }
}
