using UnityEngine;
using System.Collections;

public class MovimientoShoot : MonoBehaviour {

	public float spped = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (0, 0, spped);

	
	}
}
