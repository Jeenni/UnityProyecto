using UnityEngine;
using System.Collections;

public class TriggerPalancaPrincipal : MonoBehaviour {

		//public GameObject Palanca;
		public GameObject Puerta;
		//public float smooth = 2.0F;
			//public float tiltAngle = 30.0F;
		void OnTriggerStay (Collider col) {
				if (col.gameObject.name == "Protagonista") {
						
							//dd
								//Destroy(cubo);
								//float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
								//float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
								//Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundZ);
								//Destroy(palanca);
								//palanca.transform.rotation = Quaternion.identity;
								//palanca.transform.position = new Vector3(9, -14, -77);
								//palanca.transform.eulerAngles == Vector3(90,180,0);
			
			/*if(	(Puerta.transform.rotation.eulerAngles.x)<=80){
				Puerta.transform.Rotate(new Vector3(2,0,0));
							
												}*/

			if(	(Puerta.transform.position.y)<=11){
				Puerta.transform.Translate(0, 1, 0);}
						//print(transform.position.x);
				
								//cubo.transform.rotation = Quaternion.identity;
								//cubo.transform.rotation=Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
								//Destroy(col.gameObject);
								
		}
				
					
						//if (col.gameObject.name == "Zap") {
						
							
						//}
	}
		
}