using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volumeSetter : MonoBehaviour
{
    public AudioMixer audioMixer;
    // Start is called before the first frame update
public void SetVolume(float volume)
    {
        audioMixer.SetFloat("MainVolume", volume);
    }
}
