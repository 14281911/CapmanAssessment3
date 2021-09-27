using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTimer : MonoBehaviour
{
    void Start()
    {
        AudioSource normalstateaudio = gameObject.GetComponent<AudioSource>();
        normalstateaudio.PlayDelayed(1.5f);
    }
}
