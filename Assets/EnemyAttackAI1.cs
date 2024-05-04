using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class EnemyAttackAI1 : MonoBehaviour
{
    [SerializeField] float attackFrequency;
    [SerializeField] GameObject attackObject; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(Attack), 1, attackFrequency);   
    }

private void Attack()
{
    Instantiate(attackObject, gameObject.transform.position, Quaternion.identity);
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
