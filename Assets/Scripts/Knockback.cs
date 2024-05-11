using UnityEngine;
using System.Collections;

public class Knockback : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject effect;

    public void Apply(Vector3 direction, float strength)
    {
        rb.velocity = Vector2.zero;
        rb.AddForce(direction * strength * rb.mass, ForceMode2D.Impulse);
        StartCoroutine(DisableControls());
    }

    IEnumerator DisableControls()
    {
        if (TryGetComponent<PlayerMovement>(out PlayerMovement playerMovement))
        {
            yield return new WaitForSeconds(0.95f);
        }
    }
}
