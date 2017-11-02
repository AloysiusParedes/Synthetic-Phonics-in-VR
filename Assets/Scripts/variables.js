#pragma strict

var speed = 5.0;

function Start () {
	
}

function Update () {
	transform.Rotate(0, speed * Time.deltaTime, 0);
}
