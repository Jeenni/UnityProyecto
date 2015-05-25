var nTime : float = 10;
public var Aceleracion : float = 1;
var DisparoChoque : Transform;

function Start () {
Destroy(this.gameObject, nTime);
}

function OnCollisionEnter(){
var clone : Transform;
clone = Instantiate(DisparoChoque, transform.position, transform.rotation);
Destroy(gameObject);
}