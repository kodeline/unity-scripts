using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanciar : MonoBehaviour {
	public GameObject objeto;

	void Update() {
		
		if (Input.GetKeyDown(KeyCode.F))
			//Instantiate(Objeto, Posicion , Rotacion);
			Instantiate(objeto, transform.position, Quaternion.identity);

	}
}
