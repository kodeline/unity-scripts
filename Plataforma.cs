using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

    public float velocidadDeMovimiento;
    public float limite;

    private float recorrido;
    private bool yendo;

    void Update() {
       
        if (recorrido <=0)
            yendo = true;
        else if (recorrido >= limite)
            yendo = false;

        if(yendo) {
            transform.Translate(new Vector3(velocidadDeMovimiento * Time.deltaTime, 0, 0));
            recorrido += velocidadDeMovimiento * Time.deltaTime;
        } else {
            transform.Translate(new Vector3(-velocidadDeMovimiento * Time.deltaTime, 0, 0));
            recorrido -= velocidadDeMovimiento * Time.deltaTime;
        }
    
    }  
}
