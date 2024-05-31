using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovJugador : MonoBehaviour {
   
    public float velocidadDeMovimiento;
    public float velocidadDeRotacion;
    public float fuerzaDeSalto;
    
    private Rigidbody rb;
    private float z;
    private bool estaEnSuelo;
   
    void Start() {
        rb = GetComponent<Rigidbody>();
    }
   
    void Update() {
        MovZ();
        // Aplicamos salto mediante fuerza
        if (Input.GetKey(KeyCode.Space) && estaEnSuelo)
            rb.AddForce(Vector3.up * fuerzaDeSalto, ForceMode.Impulse);
       
        // Aplicamos movimiento modificando position mediandte fuerza

        void MovZ() {
            if (Input.GetKey(KeyCode.W))
                z = 1f;
            else if (Input.GetKey(KeyCode.S))
                z = -1f;
            else
                z = 0;
        }
        

        // Aplicamos fuerza a movimiento
        rb.AddForce(transform.forward * velocidadDeMovimiento * z);

        // Aplicamos rotacion mediante el rotate
        if (Input.GetKey(KeyCode.D))
            transform.Rotate(0f, velocidadDeRotacion * Time.deltaTime, 0f);
        else if (Input.GetKey(KeyCode.A))
            transform.Rotate(0f, -velocidadDeRotacion * Time.deltaTime, 0f);

    }

    private void FixedUpdate() {
        // Aplicamos RayCast
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), out hit, 1f)) {
            estaEnSuelo = true;
            transform.SetParent(hit.transform);
        } else {
            estaEnSuelo = false;
            transform.SetParent(null);
        }
    }
}
