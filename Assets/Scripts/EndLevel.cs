using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public ParticleSystem particles;
    public AudioClip audioClip;

    [Header("Broadcast event channels")]
    public StringEventChannel onLevelEnded;
    public PlaySoundAtEventChannel sfxAudioChannel;

    private bool hasBeenTriggered = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
            hasBeenTriggered = true;
            particles.Play();
            sfxAudioChannel.Raise(audioClip, transform.position);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}