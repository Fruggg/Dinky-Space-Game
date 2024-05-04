using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Unity.Mathematics;

public class HealthUIManager : MonoBehaviour
{
    
    [SerializeField] GameObject healthSpritePrefab;
    [SerializeField] GameObject[] healthSprites;
    [SerializeField] Transform spriteContainer;
    [SerializeField] private int health;
    [SerializeField] private int maxHealth = 3;

    public int Health
    {
        get { return health; }
        set { SetHealth(value); }
    }

    private void SetHealth(int value)
    {
        
        value = math.min(value, maxHealth);
        health = value;
        //For each value of health
        List<GameObject> spawnedSprites = spriteContainer.GetComponentsInChildren<Transform>().Select(x => x.gameObject).ToList();
        Debug.Log("hmama" + value);

       
          for (int i = spawnedSprites.Count - 1; i > value; i--)
        {
            Destroy(spawnedSprites[i]);
        }
        for (int i = 0; i < value; i++)
        {
            //if it's already there, don't waste my time
            if (spawnedSprites.Count > value)
            {
                continue;
            }
            else
            {
                //create if not there
                spawnedSprites.Insert(i, Instantiate(healthSpritePrefab, spriteContainer));
            }
        }
        //Kill the ones that don't fit the mold of my society (Excess health begone)
      
    }

}
