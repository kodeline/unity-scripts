using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoPickup : MonoBehaviour {
    
    private AudioSource sonidoFuente;
    public AudioClip colision; 
    
    void Start() {
        sonidoFuente = GetComponent<AudioSource>();    
    }

    private void OnCollisionEnter(Collision other) {
        
        if (other.gameObject.CompareTag("PickUp")) {
            sonidoFuente.PlayOneShot(colision);
        }
    }

}
