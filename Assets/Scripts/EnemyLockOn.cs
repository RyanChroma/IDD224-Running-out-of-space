using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLockOn : MonoBehaviour
{
    GameObject player => GameObject.FindGameObjectWithTag("Player");
    public float enemyLockOnSpeed = 0f;
    public Health playerHealth => GameObject.FindWithTag("Player").GetComponent<Health>();
    public float damage = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemyLockOnSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag != "Player")
        {
            return;
        }

        playerHealth.DecreaseHealth(damage);
        Destroy(gameObject);
    }
}
