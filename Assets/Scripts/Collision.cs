using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    public AudioClip Coin;
    private AudioSource audioSource;

    void Update()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((other.gameObject.tag == "Player"))
        {
            audioSource.PlayOneShot(Coin);
            Destroy(this.gameObject, .4f);
        }
    }
}

