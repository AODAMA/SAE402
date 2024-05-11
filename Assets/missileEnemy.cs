using UnityEngine;

public class Missile : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the missile
    public float damage = 1f; // Amount of damage the missile deals

    private void Start()
    {
        // Set the initial velocity to move left
        GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Damage(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Damage(other.gameObject);
            Destroy(gameObject);
        }
    }

    private void Damage(GameObject go)
    {
        go.GetComponent<PlayerHealth>().TakeDamage(damage);
    }
}