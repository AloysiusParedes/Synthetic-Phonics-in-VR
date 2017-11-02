#pragma strict

function OnMouseDown(){
	GetComponent.<Rigidbody>().AddForce(transform.forward * 500f);
	GetComponent.<Rigidbody>().useGravity = true;
}//bens a bitch