using UnityEngine;
using System.Collections;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void PlayButton (){
		Application.LoadLevel ("Hub World"); 
	}

	public void Settings (){

	}

	public void FindSquadron(){
		Application.LoadLevel ("Find Squadron"); 
	}

	public void Social (){

	}


}

