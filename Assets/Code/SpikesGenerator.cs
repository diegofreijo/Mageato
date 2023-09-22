using UnityEngine;

public class SpikesGenerator : MonoBehaviour
{
    [SerializeField] private float yMin;
    [SerializeField] private float yMax;
    [SerializeField] private int xMin;
    [SerializeField] private int xMax;
    [SerializeField] private ObstaclesTable obstaclesTable;
    // [SerializeField] private float spikesChance = 1;

    void Start()
    {
        // var spikes = new Obstacle();
        // spikes.name = "Spikes";
        // spikes.weight = 3;

        // var lava = new Obstacle();
        // lava.name = "Lava";
        // lava.weight = 1;

        // var table = new WeightedTable<Obstacle>(new System.Collections.Generic.List<Obstacle>()
        // {spikes, lava});

        // for (int i = 0; i < 10; i++)
        // {
        //     Debug.Log(table.Evaluate().name);
        // }



        for (int x = xMin; x <= xMax; x++)
        {
            CreateObstacle(x);
        }
    }

    private void CreateObstacle(int x)
    {
        var y = Random.Range(yMin, yMax);

        var obstacle = obstaclesTable.Evaluate();

        GameObject spikesGo = Instantiate(obstacle.Prefab, transform);
        spikesGo.transform.position = new Vector2(x, y);
    }
}
