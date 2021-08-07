using UnityEngine;

public class DataGame : MonoBehaviour
{
    public static DataGame _instantion;

    public delegate void ShowInfo(int count, int countEnemy);
    public ShowInfo show;

    [SerializeField] private GameObject panelLose;
    [SerializeField] private GameObject panelWin;


    private int countHealth = 3;
    private int countEnemy = 6;
    

    public int CountHealth
    {
        get => countHealth;
        private set => countHealth = value;
    }

    public int CountEnemy
    {
        get => countEnemy;
        private set => countEnemy = value;
    }

  

    void Awake()
    {
        if (!_instantion)
        {
            _instantion = this;
        }
    }

    public void DecreaseHealth()
    {
        if (countHealth > 1) countHealth--;
        else
        {
            Time.timeScale = 0;
            panelLose.SetActive(true);
        }

        show(countHealth, countEnemy);
    }

    public void DecreaseEnemy()
    {
        if (countEnemy > 1) countEnemy--;
        else
        {
            Time.timeScale = 0;
            panelWin.SetActive(true);
        }
        show(countHealth, countEnemy);
    }
}
