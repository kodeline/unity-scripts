using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour {
    public void CambiarEscena(string nombreDeEscena) {
         SceneManager.LoadScene(nombreDeEscena);
    }
}
