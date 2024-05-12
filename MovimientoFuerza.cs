using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class MovimientoFuerza : MonoBehaviour {
   
    public float velocidad = 5f;
    
    float alturaSalto = 5f;
    float velocidadSalto = 2f;

    void Update() {
   
        float movimientoHorizontal = 0f;
        float movimientoProfundidad = 0f;

        // Movimiento Horizontal
        if (Input.GetKey(KeyCode.D))
            movimientoHorizontal = 1f;
        else if(Input.GetKey(KeyCode.A))
            movimientoHorizontal = -1f;
       
        // Movimiento Hacia adelante
        if (Input.GetKey(KeyCode.W))
            movimientoProfundidad = 1f;
        else if(Input.GetKey(KeyCode.S))
            movimientoProfundidad = -1f;
       
        //Calculamos la fuerza de Movimiento
        Vector3 movimiento = new Vector3(movimientoHorizontal, 0f, movimientoPronfudidad);

        // Aplicamos esa fuerza al RigidBody
        GetComponent<Rigidbody>().AddForce(movimiento * velocidad);

        if(Input.GetKey(KeyCode.Space)) {
            transform.Translate(Vector3.up * alturaSalto * velocidadSalto * Time.deltaTime);
        }
    }

}
