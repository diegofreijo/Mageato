using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private Obstacle obstacle;

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        health.Damage(obstacle.Damage);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Quemando jugador!");
        var health = other.gameObject.GetComponent<Health>();
        health.Damage(obstacle.Damage);
    }
}
