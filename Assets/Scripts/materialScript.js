#pragma strict


private var orange : Color = Color(0.8, 0.4, 0.0, 0.7);
private var red : Color = Color(1.0, 0.0, 0.0, 1.0);
var newMaterial : Material;
var change = 1;




function Start () {
	
}

function Update () {

	if(Input.GetButtonDown("Fire1")){
		GetComponent.<Renderer>().material.color = orange;
		newMaterial.color = orange;
		change++;
	}

	if(Input.GetButtonDown("Fire2")){
		GetComponent.<Renderer>().material.color = red;
		newMaterial.color = red;
		change++;
	}

}
