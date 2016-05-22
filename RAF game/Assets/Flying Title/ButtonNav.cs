using UnityEngine;
using System.Collections;

public class ButtonNav : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AgainstTheClock(){
		Application.LoadLevel("Flying Game");
	}

	public void Expert() {
		Application.LoadLevel("Flying Game Expert");
	}

	public void Back() {
		Application.LoadLevel("Hub World"); 
	}


}
