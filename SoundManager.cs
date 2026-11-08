using System;
using System.Collections.Generic;
using UnityEngine;

public enum soundtypes
{
    PistolReload,
    PistolSFX
}

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{
    [SerializeField] private Soundlist[] soundlist;
    private static SoundManager instance;
    private AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private static void PlaySound(soundtypes sound, float volume = 1.0f)
    {
        AudioClip[] Sounds = instance.soundlist[(int)sound].sound;
        AudioClip PlayRandomsound = sound[UnityEngine.Random.Range(0, Sounds.Length)];
        instance.audioSource.PlayOneShot(PlayRandomsound, volume);

    }
}

[Serializable]
public struct Soundlist
{
    [SerializeField] private string name;
    [SerializeField] public AudioClip[] Sounds;
}
