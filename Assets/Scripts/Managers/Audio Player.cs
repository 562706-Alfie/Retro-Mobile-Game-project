using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioManagerSO audioManager;
    public AudioSource audioSource;

    private void OnEnable()
    {
        Debug.Log("AudioPlayer enabled and subscribed!");

        if (audioManager != null)
            audioManager.OnPlaySound += PlaySound;
    }

    private void OnDisable()
    {
        if (audioManager != null)
            audioManager.OnPlaySound -= PlaySound;
    }

    private void PlaySound(AudioClip clip, bool loop)
    {
        Debug.Log("AudioPlayer received: " + clip.name);

        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.loop = loop;
        audioSource.Play();

        Debug.Log("AudioSource playing: " + audioSource.isPlaying);
    }
}