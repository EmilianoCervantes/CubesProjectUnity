using UnityEngine;
using System.Collections;

public class Fire : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		// Identificamos si se presionó el botón Fire1
		if (Input.GetButtonDown("Fire1")) {
			// Obtenemos la posición del mouse y creamos un rayo a partir de 
			// esta posición
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			// Creamos una primitiva
			GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
			// A la posición de la primitiva le damos la posición del origen del
			// rayo
			sphere.transform.position = ray.origin;
			// Obtenemos un color aleatorio y se lo asignamos al material de la
			// primitiva
			sphere.GetComponent<Renderer>().material.color = new Color (Random.Range(0.0f, 1.0f),
				Random.Range(0.0f, 1.0f),
				Random.Range(0.0f, 1.0f));
			// A la primitiva le agregamos el componente rigidbody
			sphere.AddComponent<Rigidbody>();
			// Le agregamos fuerza a la primitiva con la dirección que tiene 
			// el rayo
			sphere.GetComponent<Rigidbody>().AddForce(ray.direction * 1000);
		}
	}
}