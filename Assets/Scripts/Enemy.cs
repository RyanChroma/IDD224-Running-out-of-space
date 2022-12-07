using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Health playerHealth => GameObject.FindWithTag("Player").GetComponent<Health>();
    public float damage = 0f;
    public static Action onEnemyDead;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag != "Floor")
        {
            return;
        }

        playerHealth.DecreaseHealth(damage);
        Destroy(gameObject);
        onEnemyDead?.Invoke();
    }

    public void EnemyDead()
    {
        onEnemyDead?.Invoke();
    }
}
