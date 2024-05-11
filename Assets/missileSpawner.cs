using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject missilePrefab; 
    public float spawnDistance = 5f; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Calculate the spawn position based on the spawn distance and spawner's position
            Vector2 spawnPosition = transform.position + (Vector3.right * spawnDistance);

            // Spawn a missile at the calculated position
            Instantiate(missilePrefab, spawnPosition, Quaternion.identity);
        }
    }
}