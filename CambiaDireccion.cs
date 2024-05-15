using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaDireccion : MonoBehaviour {

    public float dir = 1f;
    public float velocidad = 3f;
   
    void Update() {
        transform.Translate(new Vector3( dir,0,0 ) * Time.deltaTime * velocidad );
    }

    private void OnTriggerEnter(Collider otro) {
        if(otro.CompareTag("Transparente"))
            dir *= (-1);
    }
   
}
