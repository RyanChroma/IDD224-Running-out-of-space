using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int targetEnemy;
    public static int score;
    public static Action onWin;

    void Start()
    {
        targetEnemy = GameObject.FindGameObjectsWithTag("Enemy").Count();
    }

    void Update()
    {
        
    }

    private void OnEnable()
    {
        Enemy.onEnemyDead += IncreaseScore;
    }

    private void OnDisable()
    {
        Enemy.onEnemyDead -= IncreaseScore;
    }

    public void IncreaseScore()
    {
        score += 1;

        if(score >= targetEnemy)
        {
            onWin?.Invoke();
        }
    }
}
