using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Sound 
{
    public string name;
    [Range(0f,1f)]
    public float volume;
    [Range(0.1f,3f)]
    public float pitch;
    public bool loop;
    public AudioClip clip;
    [HideInInspector]
    public AudioSource source;
}
