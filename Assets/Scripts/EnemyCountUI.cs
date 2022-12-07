using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyCountUI : MonoBehaviour
{
    public Text enemyCount;
    public GameManager gameManager => GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();

    void Start()
    {
        
    }

    void Update()
    {
        enemyCount.text = (gameManager.targetEnemy - GameManager.score).ToString();
    }
}