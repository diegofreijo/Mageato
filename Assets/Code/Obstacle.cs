using UnityEngine;

[CreateAssetMenu(fileName = "Obstacle", menuName = "Mageato/Obstacle", order = 0)]
public class Obstacle : ScriptableObject, IWeightable
{
    [SerializeField] private int damage = 10;
    [SerializeField] private string obstacleName;
    [SerializeField] private GameObject prefab;
    [SerializeField] int weight;

    public int Damage => damage;
    public int Weight => weight;
    public GameObject Prefab => prefab;
}
