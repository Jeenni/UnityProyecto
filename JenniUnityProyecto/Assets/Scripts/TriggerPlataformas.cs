using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerPlataformas : MonoBehaviour {
	public GameObject PlataformaInicio;
	public GameObject PlataformaInicio1;
	public GameObject PlataformaInicio2;
	public GameObject PlataformaInicio3;
	public GameObject PlataformaInicio4;
	public GameObject PlataformaInicio5;
	public GameObject PlataformaInicio6;
	public GameObject PlataformaInicio7;
	public GameObject PlataformaInicio8;
	public GameObject PlataformaInicio9;
	public GameObject PlataformaInicio10;
	public GameObject PlataformaInicio11;
	private float time = 0.0f;
	private readonly float timeStep = 1.0f;
	private List<GameObject> plataformas;
	public bool trigger = false;

	void Start()
	{
		//Las hacemos invisibles
		plataformas = new List<GameObject> ();
		plataformas.Add (PlataformaInicio);
		plataformas.Add (PlataformaInicio1);
		plataformas.Add (PlataformaInicio2);
		plataformas.Add (PlataformaInicio3);
		plataformas.Add (PlataformaInicio4);
		plataformas.Add (PlataformaInicio5);
		plataformas.Add (PlataformaInicio6);
		plataformas.Add (PlataformaInicio7);
		plataformas.Add (PlataformaInicio8);
		plataformas.Add (PlataformaInicio9);
		plataformas.Add (PlataformaInicio10);
		plataformas.Add (PlataformaInicio11);
		foreach(GameObject p in plataformas)  p.GetComponent<MeshRenderer>().enabled = false;
	}
	
	void Update()
	{
		if (trigger == true) {
			time += Time.deltaTime;
			int plataformaQueToca = (int)(time / timeStep);
			if (plataformaQueToca <= plataformas.Count) 
				plataformas [plataformaQueToca].GetComponent<MeshRenderer> ().enabled = true;
		}
	}
	void OnTriggerStay (Collider col) {
		if (col.gameObject.name == "Protagonista") {
			trigger = true;
		}
	}
}