using UnityEngine;

public class BalaEnemiga : MonoBehaviour {
    private Rigidbody rb;
    public float velocidad;
    private float timer;
    public float tiempoDeDestruir;

    void Start() {
        rb = GetComponent<Rigidbody>();
        timer = tiempoDeDestruir;
    }

    void Update() {

        rb.linearVelocity = transform.forward * velocidad;
        // Destruir la bala después de un tiempo
        if (timer > 0) 
            timer -= Time.deltaTime;
        else
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider colision) {
        if (colision.gameObject.tag == "Jugador"){
            colision.gameObject.GetComponent<Jugador>().quitarVida();
            Destroy(gameObject);
        }
    }

}

