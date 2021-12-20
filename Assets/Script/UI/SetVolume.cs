using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void Volume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
