using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*  Este Script nos permite restarle vida a un personaje hasta que muera siempre 
    que entre en colision con algun otro objeto. */
    
public class RestarVida : MonoBehaviour {
    
    public int vida = 5;

    private void OnTriggerEnter(Collider colision) {
        if(colision.gameObject.CompareTag("Transparente")) {
            vida--;
            Debug.Log("Daño Recibido. Vida Restante: " + vida);
            if(vida <= 0) {
                Destroy(gameObject);
            }
        }  
    }
}
