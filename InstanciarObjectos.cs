using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciarObjectos : MonoBehaviour {

    public GameObject objeto;
   
    void Update() {
        
        if(Input.GetKeyDown(KeyCode.F))
            // Instatiate (objeto, posicion, rotacion)
            Instantiate(objeto, transform.position, Quaternion.identity);

    }
}
