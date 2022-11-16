using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    public float health = 0f;
    public UnityEvent onDeadEvent;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void DecreaseHealth(float decreaseHealth)
    {
        health -= decreaseHealth;

        if(health <= 0f)
        {
            onDeadEvent.Invoke();
        }
    }
}
