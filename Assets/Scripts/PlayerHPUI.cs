using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPUI : MonoBehaviour
{
    public Text playerHealthUI;
    public Health playerHealth => GameObject.FindGameObjectWithTag("Player").GetComponent<Health>();

    void Start()
    {
        
    }

    void Update()
    {
        playerHealthUI.text = playerHealth.health.ToString();
    }
}