using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public string scName = "Credits";
    private bool hasBeenTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
            hasBeenTriggered = true;
            SceneManager.LoadScene(scName);
    }
}