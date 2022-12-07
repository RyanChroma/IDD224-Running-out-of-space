using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int targetEnemy;
    public static int score;
    public static Action onWin;

    void Start()
    {
        score = 0;
        targetEnemy = GameObject.FindGameObjectsWithTag("Enemy").Count();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("mainmenu");
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 1;
        }
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

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }    
}
