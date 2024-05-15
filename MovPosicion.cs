using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovPosicion : MonoBehaviour {

    private float movimientoX;
    private float movimientoZ;

    void Update() {
        DireccionX();
        DireccionZ();        
    }

    void DireccionX() {

        if(Input.GetKey(KeyCode.A)) {
            movimientoX = (-1f);
        } else if(Input.GetKey(KeyCode.D)) {
            movimientoX = 1f;
        }     
    }

    void DireccionZ() {
        
        if(Input.GetKey(KeyCode.W)) {
            movimientoZ = 1f;
        } else if(Input.GetKey(KeyCode.S)) {
            movimientoZ = (-1f);
        }     
    }
}
