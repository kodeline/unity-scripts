using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovObstaculo : MonoBehaviour {

    public float dir = 1f;
    public float velocidad = 3f;
    

    void Update() {
        transform.Translate(new Vector3( dir,0,0 ) * Time.deltaTime * velocidad );
    }

    private void OnTriggerEnter(Collider otro) {
        if(otro.CompareTag("Transparente"))
            dir *= (-1);
    }

    void DireccionX() {

        float movimientoX = 0f;

        if(Input.GetKey(KeyCode.A)) {
            movimientoX = (-1f);
        } else if(Input.GetKey(KeyCode.D)) {
            movimientoX = 1f;
        }     
    }

    void DireccionZ() {

        float movimientoZ = 0f;
        
        if(Input.GetKey(KeyCode.W)) {
            movimientoZ = 1f;
        } else if(Input.GetKey(KeyCode.S)) {
            movimientoZ = (-1f);
        }     
    }
}
