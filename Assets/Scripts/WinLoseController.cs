using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseController : MonoBehaviour
{
    public GameObject canvasWin;
    public GameObject canvasLose;

    public void ShowWin()
    {
        canvasWin.SetActive(true);
        Time.timeScale = 0;
    }

    public void ShowLose()
    {
        canvasLose.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnEnable()
    {
        GameManager.onWin += ShowWin;
        Player.onLose += ShowLose;
    }

    private void OnDisable()
    {
        GameManager.onWin -= ShowWin;
        Player.onLose -= ShowLose;
    }
}
