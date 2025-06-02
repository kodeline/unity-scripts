using UnityEngine;
using TMPro;

public class Jugador : MonoBehaviour{
    private float velocidad;
    private float ascelerar = 6f;
    private float desascelerar = 2f;
    private Rigidbody rb;
    private int vida = 5;
    public int danio;
    public GameObject bala;
    public Transform salidaBala;
    public float velocidadDisparo;
    public TextMeshProUGUI textoVida;
    
    void Start() {
        rb = GetComponent<Rigidbody>();
    }

    void Update(){

        disparar();
        cambiarMovimiento();
        //quitarVida();

        textoVida.text = "x" + vida;

        float movimientoProfundidad = 0f;
        // Movimiento Hacia adelante
        if (Input.GetKey(KeyCode.W))
            movimientoProfundidad = 1f;
        else if (Input.GetKey(KeyCode.S))
            movimientoProfundidad = -1f;

        //Calculamos la fuerza de Movimiento
        Vector3 movimiento = new Vector3(0f, 0f, movimientoProfundidad);

        // Aplicamos esa fuerza al RigidBody
        rb.AddForce(movimiento * velocidad);
        
    }

    private void cambiarMovimiento() {
        // Cambiar la velocidad de movimiento al presionar Shift
        if (Input.GetKey(KeyCode.LeftShift))
            velocidad = ascelerar;
        else
            velocidad = desascelerar;
    }

    private void disparar() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            GameObject balaClon = Instantiate(bala, salidaBala.position, Quaternion.identity);
            balaClon.GetComponent<Rigidbody>().AddForce(transform.right * velocidadDisparo, ForceMode.Impulse);
        }
    }
    
    public void quitarVida() {
        vida -= danio;
        if (vida <= 0)
            Destroy(gameObject);
    }
    
}
