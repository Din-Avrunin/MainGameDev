
using UnityEngine;
using UnityEngine.Audio;

public class SettingMenu : MonoBehaviour
{
    public  AudioMixer audioMixer;
    public void SetVolume(float vol)
    {
        audioMixer.SetFloat("VolumeGame", vol);
    }
}



