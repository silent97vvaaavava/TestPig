using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenu : MonoBehaviour
{
    [SerializeField] private GameObject panelPause;

    public void StopAndStart()
    {
        Time.timeScale = Time.timeScale > 0 ? 0 : 1;
        panelPause.SetActive(!panelPause.activeSelf);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
