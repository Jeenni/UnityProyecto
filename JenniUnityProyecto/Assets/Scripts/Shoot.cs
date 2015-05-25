using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

		
		//public Rigidbody projectile;
		
		public float speed = 20;
		
		
		
		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () {
			
			if (Input.GetKey(KeyCode.T))
			{
				/*Rigidbody instantiatedProjectile = Instantiate(Proyectil,
				                                               transform.position,
				                                               transform.rotation)
					as Rigidbody;
				
				instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0,speed));*/
			Vector3 origin = transform.position + Vector3.up * 1.0f;
			
			GameObject proj = Instantiate(Resources.Load("bala"), 
			                              origin, Quaternion.identity) as GameObject;
			
			Vector3 shootDir = (Camara.GetLookPoint() - origin).normalized;
			/*if(target != null) 
			{
				shootDir = (target.transform.position - origin).normalized;
			}*/

			
			proj.GetComponent<Projectile>().dir = shootDir;
			proj.transform.forward = shootDir; 
			//proj.GetComponent<Projectile>().shooterPlayer = this;

				
			}
		}
	}

