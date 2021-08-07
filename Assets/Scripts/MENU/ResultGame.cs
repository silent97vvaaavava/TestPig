using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultGame : MonoBehaviour
{
    [SerializeField] private Text countHealth;
    [SerializeField] private Text countEnemy;

    void Start()
    {
        DataGame._instantion.show = UpdateInfo;
    }

    void UpdateInfo(int countH, int countF)
    {
        countHealth.text = countH.ToString();
        countEnemy.text = countF.ToString();
    }

}
