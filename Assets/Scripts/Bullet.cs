using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 0f;

    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.GetComponent<Health>().DecreaseHealth(damage);
        Destroy(gameObject);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
