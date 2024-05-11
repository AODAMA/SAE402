using UnityEngine;

public class Wall: MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the missile

    private void Start()
    {
        // Set the initial velocity to move left
        GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, 0);
    }

}