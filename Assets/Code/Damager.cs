using UnityEngine;

public class Damager : MonoBehaviour
{
    [SerializeField] private int damage = 10;

    /// <summary>
    /// Sent when an incoming collider makes contact with this object's
    /// collider (2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>
    void OnCollisionEnter2D(Collision2D other)
    {
        var health = other.gameObject.GetComponent<Health>();
        health.Damage(damage);
    }
}
