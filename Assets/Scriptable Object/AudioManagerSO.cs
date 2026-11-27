using UnityEngine;
using System;
using System.Collections.Generic;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip audioClip;
    public bool loop;
}

[CreateAssetMenu(menuName = "Managers/Audio Manager")]
public class AudioManagerSO : ScriptableObject
{
    public List<Sound> audioClips = new List<Sound>();

    public event Action<AudioClip, bool> OnPlaySound;

    public void PlaySound(int index)
    {
        if (index < 0 || index >= audioClips.Count)
            return;

        Sound sound = audioClips[index];

        if (sound.audioClip == null)
        {
            Debug.LogWarning("AudioClip is missing!");
            return;
        }

        Debug.Log("Requesting sound: " + sound.soundName);

        OnPlaySound?.Invoke(sound.audioClip, sound.loop);
    }
}