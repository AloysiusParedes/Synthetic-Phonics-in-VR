#pragma strict

function Start () {
	
}

function Update () {
	if(Input.GetKey("up"))
		print("up arrow key is held down");
	if(Input.GetKey("up"))
		print("up arrow key is held down");
	if(Input.GetKey(KeyCode.Space))
		GetComponent.<Rigidbody>().AddForce(transform.forward * 200f);
}
