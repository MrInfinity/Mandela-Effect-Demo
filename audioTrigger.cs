using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioTrigger : MonoBehaviour
{
    public AudioClip CSAudio;
    AudioSource audioSource;
    
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter() {
        audioSource.PlayOneShot(CSAudio, 0.7F);
    }
}