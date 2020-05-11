
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;


public class RandomMoo : MonoBehaviour
{

    private AudioSource source { get { return GetComponent<AudioSource>(); } }
    public AudioClip sound;

    public AudioMixerGroup audioMixer;


    public float time = 4f;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;
        StartCoroutine("PlayMoo");
    }

    IEnumerator PlayMoo()
    {
        while (true)
        {
            source.outputAudioMixerGroup = audioMixer;
            float random = Random.Range(0f, 100f);
            if (random < 40f)
            {
                source.PlayOneShot(sound);
            }
            yield return new WaitForSeconds(time);
        }
    }

   
}
