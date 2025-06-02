using UnityEngine;

public class Bala : MonoBehaviour {
    private void OnCollisionEnter(Collision colision) {
        if(colision.gameObject.tag == "Mar")
            Destroy(gameObject);
    }
}
