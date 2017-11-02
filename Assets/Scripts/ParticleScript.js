#pragma strict
public var confettiEmitter:ParticleSystem;

function Start () {
 confettiEmitter = GameObject.Find("Confetti").GetComponent(ParticleSystem);
}

function Update () {
	if(Input.GetButtonDown("Fire1"))confettiEmitter.Emit(20);

}