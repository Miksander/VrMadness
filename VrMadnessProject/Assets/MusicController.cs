using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class MusicController : MonoBehaviour
{
    void Awake()
    {
        AudioSource audioSrc = GetComponent<AudioSource>();
        audioSrc.ignoreListenerVolume = true;
        audioSrc.Play();
    }
}
