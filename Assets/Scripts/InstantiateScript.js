#pragma strict
var prefabSphere : Transform;
function Start () {
	
}

function Update () {
	if(Input.GetButton("Jump"))
		var instanceObject = Instantiate(prefabSphere, transform.position, transform.rotation);
}
