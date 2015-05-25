#pragma strict

private var pauseGame : boolean = false;
private var showGUI : boolean = false;

function Update(){

	if(Input.GetKeyDown("p")){
	pauseGame = !pauseGame;
	
	if(pauseGame ==  true){
		Time.timeScale = 0;
		pauseGame = true;
		//GameObject.Find("Camara").GetComponent(MouseLook).enable = false;
		//GameObject.Find("Personaje").GetComponent(MouseLook).enable = false;
		showGUI = true;
		}
	}
	if( pauseGame == false){
		Time.timeScale = 1;
		pauseGame = false;
		//GameObject.Find("Camara").GetComponent(MouseLook).enable = true;
		//GameObject.Find("Personaje").GetComponent(MouseLook).enable = true;
		showGUI = true;
		
	}
	if(showGUI == true){
		GameObject.Find("Canvas").GetComponent.<GUITexture>().enabled = true;
		//GameObject.Find("Text").
	}
	else {
		GameObject.Find("Canvas").GetComponent.<GUITexture>().enabled = false;
	}
}