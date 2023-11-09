using System.Collections;
using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private Obstacle obstacle;

    void OnCollisionEnter2D(Collision2D other)
    {
        Damage(other.gameObject.GetComponent<Health>());
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Damage(other.gameObject.GetComponent<Health>());
    }

    private void Damage(Health health)
    {
        Debug.Log("Quemando jugador!");
        health.Damage(obstacle.Damage);

        StartCoroutine(WaitAndDie());
    }

    private IEnumerator WaitAndDie()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log($"Esperando en el segundo {i}");
            yield return new WaitForSeconds(1f);
        }
        Destroy(gameObject);
    }
}
