using UnityEngine;
using System.Collections;

public class NPC_Dialog : MonoBehaviour {
	
	public string[] answerButtons;
	public string[] Questions;
	bool DisplayDailog = false;
	bool a = false;
	bool ActivateQuestSiesqueno = false;
	bool Activa3 = false;
	bool Activa4 = false;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		GUILayout.BeginArea (new Rect (700, 600, 400, 400));
		
		if (DisplayDailog && !a && !ActivateQuestSiesqueno && !Activa3) {
			
			//Puedes ayudarme
			GUILayout.Label(Questions[0]);
			
			
			if(GUILayout.Button(answerButtons[0])){//si
				a = true;
				
				//DisplayDailog = false;
				ActivateQuestSiesqueno=false;
			}
			if(GUILayout.Button(answerButtons[1])){//No
				
				ActivateQuestSiesqueno=true;
				
				//DisplayDailog= false;
				a = false;
				
				
			}
		}
		
		//Si es que no
		if (DisplayDailog && ActivateQuestSiesqueno) {
			GUILayout.Label(Questions[3]);
			
			if(GUILayout.Button(answerButtons[4])){
				DisplayDailog= false;
				ActivateQuestSiesqueno=false;
			}
			
			
			
		}
		
		//si es que si
		if (DisplayDailog && a && !Activa3 && !Activa4) {
			GUILayout.Label(Questions[1]);
			//si
			if(GUILayout.Button(answerButtons[2])){
				//DisplayDailog = false;
				Activa3 = true;
				
			}
			//no
			if(GUILayout.Button(answerButtons[3])){
				//DisplayDailog = false;
				Activa4 = true;
				
			}
		}
		//no
		if (DisplayDailog && Activa4) {
			GUILayout.Label(Questions[4]);
			
			if(GUILayout.Button(answerButtons[4])){
				DisplayDailog= false;
				Activa4=false;
			}
			
			
			
		}
		//Hay un mecanism
		if (DisplayDailog && Activa3) {
			GUILayout.Label(Questions[2]);

			if(GUILayout.Button(answerButtons[4])){
				DisplayDailog= false;
				Activa3=false;
			}


			
		}
		GUILayout.EndArea ();
		
		
	}
	void OnTriggerEnter(Collider col){
		if (col.gameObject.name == "Protagonista") {
			DisplayDailog = true;
		}
		
	}
	void ObnTriggerExit(){
		DisplayDailog = false;
	}
}
