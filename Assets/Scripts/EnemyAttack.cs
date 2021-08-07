using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            DataGame._instantion.DecreaseHealth();
            other.gameObject.SetActive(false);
            other.transform.position = DataNodePosition._instantion.NodesPosition[new System.Random().Next(100)];
            other.gameObject.SetActive(true);

        }
    }
}
