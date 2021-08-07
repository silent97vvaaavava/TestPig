using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject[] enemys;

    private System.Random random;
    private int countEnemy = 0;


    void Start()
    {
        random = new System.Random();
        InvokeRepeating("Spawn", 0, 20f);
    }

    void Spawn()
    {
        if (countEnemy <= 6)
        {
            int index = random.Next(enemys.Length);
            var temp = Instantiate(enemys[index], SetPosition(), Quaternion.identity);
            temp.transform.SetParent(transform);
            countEnemy++;
        }
    }

    Vector2 SetPosition()
    {
        int index = random.Next(DataNodePosition._instantion.NodesPosition.Count);
        return DataNodePosition._instantion.NodesPosition[index];
    }
}
