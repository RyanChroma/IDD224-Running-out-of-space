using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Action onLose;
    
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void OnDead()
    {
        onLose?.Invoke();
    }
}
