#pragma strict

var target : Collider; //should be assigned in inspector
var FirstPersonController : GameObject; //should be assigned in inspector
var key : Collider; //should be assigned in inspector

function OnTriggerEnter(other : Collider){
	FirstPersonController.transform.position.x = -3;
	FirstPersonController.transform.position.y = 1;
	FirstPersonController.transform.position.z = -2;

	key.transform.parent = FirstPersonController.transform;
}

function Start () {
	
}

function Update () {
	if(Input.GetButtonDown("Fire1"))
		key.transform.parent = FirstPersonController.transform;
	if(Input.GetButtonDown("Fire2"))
		key.transform.parent = null;
}
