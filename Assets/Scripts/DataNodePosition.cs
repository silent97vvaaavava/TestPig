using System.Collections.Generic;
using UnityEngine;

public class DataNodePosition : MonoBehaviour
{
    private List<Vector2> nodesPosition = new List<Vector2>();

    public static DataNodePosition _instantion;

    public List<Vector2> NodesPosition => nodesPosition;

    void Awake()
    {
        if (!_instantion)
        {
            _instantion = this;
        }
    }

    void Start()
    {
        var gg = AstarPath.active.data.gridGraph;

        gg.GetNodes(node =>
        {
            NodesPosition.Add((Vector3)node.position);
        });
    }

   
}
