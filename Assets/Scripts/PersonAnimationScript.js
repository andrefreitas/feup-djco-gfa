#pragma strict

private var thirdPersonController : ThirdPersonController;
private var personAnimation : Animation;
private var animDisabled : boolean = false;

function Start () {
	thirdPersonController = GetComponent(ThirdPersonController);
	personAnimation = GetComponent(Animation);
}

function Update () {
	if(thirdPersonController.IsJumping()) {
		if(!animDisabled) {
			Debug.Log("JUMPING");
			personAnimation.enabled = false;
			animDisabled = true;
		}
	}
	
	else if(!thirdPersonController.IsMoving()) {
		if(!animDisabled) {
			Debug.Log("STOPPED");
			personAnimation.enabled = false;
			animDisabled = true;
		}
	}
	
	else {
		if(animDisabled) {
			Debug.Log("MOVING");
			personAnimation.enabled = true;
			animDisabled = false;
		}
	}
}