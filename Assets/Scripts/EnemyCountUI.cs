using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCountUI : MonoBehaviour
{
    public Text enemyCount;

    void Start()
    {
        
    }

    void Update()
    {
        enemyCount.text = (GameManager.targetEnemy - GameManager.score).ToString();
    }
}