using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 0f;
    public static Action onHit;

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.GetComponent<Health>().DecreaseHealth(damage);
        Destroy(gameObject);

        onHit?.Invoke();
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
