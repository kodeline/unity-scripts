using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float cadenciaDisparo;
    public GameObject bala;
    public Transform salidaBala;
    private float timer;

    private void Start(){
        timer = cadenciaDisparo;
    }
    
    void Update() {
        if (timer > 0) {
            timer -= Time.deltaTime;
        } else {
           Disparar();
            timer = cadenciaDisparo; 
        }
            
    }

    private void Disparar() {
        Instantiate(bala, salidaBala.position, transform.rotation);
    }

}
