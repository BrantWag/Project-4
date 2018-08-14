using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour {

    public AudioClip falling;
    private AudioSource audioSource;

    void Update()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            audioSource.PlayOneShot(falling);
        }
    }
}
