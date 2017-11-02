#pragma strict
var timeRemaining = 3.0;
function Start () {
	
}

function Update () {
	timeRemaining -= Time.deltaTime;
	if(timeRemaining <= 0.0)
		Destroy(gameObject); 
}
