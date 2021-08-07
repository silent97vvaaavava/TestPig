using Pathfinding;
using UnityEngine;

public class MovmentEnemy : MonoBehaviour
{
    private AIDestinationSetter target;
    delegate void getPoint();

    private getPoint SetPosition;

    void Awake()
    {
        SetPosition = UpdateTarget;
    }

    void Start()
    {
        target = GetComponent<AIDestinationSetter>();
    }

    void Update()
    {
        SetPosition();
    }

    void UpdateTarget()
    {
        if (Vector2.Distance(transform.position, target.target.position) < 1f)
        {
            target.target.position = GetRandom();
        }
    }

    Vector2 GetRandom()
    {
        System.Random random = new System.Random();
        int index = random.Next(DataNodePosition._instantion.NodesPosition.Count);
        return DataNodePosition._instantion.NodesPosition[index];
    }
}
