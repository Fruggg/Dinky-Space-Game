using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_PurpleShip : MonoBehaviour, EntityBase
{
    public PlayerScoreHandler playerScore;
    [SerializeField] private GameObject ExplosionFX;
    public void TakeDamage()
    {
        Die();
    }
    private void Die()
    {
        playerScore.score += playerScore.kScorePerEnemy;
        FindAnyObjectByType<EnemyTracker>().EnemiesAlive-= 1;
        Instantiate(ExplosionFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

 
}
