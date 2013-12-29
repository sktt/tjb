#pragma strict

function Start () {

}

function Update () {
	if(Input.GetButton("Fire1") ) {
		if(!animation.IsPlaying("attackanim")) {
			animation.Play("attackanim");
		}
	} else {
		animation.Stop("attackanim");
	}
}