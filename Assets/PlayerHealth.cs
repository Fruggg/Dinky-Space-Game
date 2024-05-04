using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour, EntityBase
{
    [SerializeField] GameObject explosionDeathObject;
    [SerializeField] int startingHealth = 3;
    [SerializeField] int currentHealth;
    [SerializeField] HealthUIManager healthUI;

    public void TakeDamage()
    {
        SetHealth(currentHealth - 1);
        
    }

    private void SetHealth(int v)
    {
        currentHealth = v;
        healthUI.Health = currentHealth;
        if (currentHealth <= 0)
        {
            
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadSceneAsync(2);
        Instantiate(explosionDeathObject, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
        //provide illusion of destroying it
        // GetComponentInChildren<SpriteRenderer>().enabled = false;
   
    }

    // Start is called before the first frame update
    void Start()
    {
        SetHealth(startingHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
