using UnityEngine;
using System.Collections;

public class Notes : MonoBehaviour {

	public AudioSource Note1Beat; 


	// Use this for initialization
	void Start () {
		if (gameObject.name == "note1(Clone)") {
			GetComponent<Rigidbody> ().velocity = new Vector3 (-0.4f,-3,0); 
		}
		if (gameObject.name == "note2(Clone)") {
			GetComponent<Rigidbody> ().velocity = new Vector3 (-0.05f,-3,0); 
		}
		if (gameObject.name == "note3(Clone)") {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0.35f,-3,0); 
		}

		Note1Beat = GetComponent<AudioSource> (); 
	}
	
	// Update is called once per frame
	void Update () {


		if ((SongControl.destroyNote1 == "Yes") && (gameObject.name == "note1(Clone)") && (transform.position.y <= -3.5)) {
			if (SongControl.multiplierScore >= 5) {
				SongControl.Score +=2; 
			}
			SongControl.Score +=1; 
			SongControl.multiplierScore +=1; 


			Destroy (gameObject);
			SongControl.destroyNote1 = "NO"; 
		}
		if ((SongControl.destroyNote2 == "Yes") && (gameObject.name == "note2(Clone)") && (transform.position.y <= -3.5)) {
			if (SongControl.multiplierScore >= 5) {
				SongControl.Score +=2; 
			}
			SongControl.Score +=1; 
			SongControl.multiplierScore +=1; 


			Destroy (gameObject);
			SongControl.destroyNote2 = "NO";
		}
		if ((SongControl.destroyNote3 == "Yes") && (gameObject.name == "note3(Clone)") && (transform.position.y <= -3.5)) {
			if (SongControl.multiplierScore >= 5) {
				SongControl.Score +=2; 
			}
			SongControl.Score +=1; 
			SongControl.multiplierScore +=1; 


			Destroy (gameObject);
			SongControl.destroyNote3 = "NO";
		}
	}

	void OnMouseDown(){
		if ((gameObject.name == "note1(Clone)") && (transform.position.y <= -2.5)) {
			Note1Beat.Play (); 
		}
		if ((gameObject.name == "note2(Clone)") && (transform.position.y <= -2.5)) {
			Note1Beat.Play (); 
		}
		if ((gameObject.name == "note3(Clone)") && (transform.position.y <= -2.5)) {
			Note1Beat.Play (); 
		}
	}



	void OnTriggerEnter (Collider Col) 
	{
		if (Col.gameObject.name == ("GuitarStrings NEW")) {
			GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0);  

		}
	}
	void OnTriggerExit (Collider Col) {
		if (Col.gameObject.name == ("GuitarStrings NEW")) {
			GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0);
			SongControl.Score -=1; 
			SongControl.multiplierScore =0; 
			Destroy (gameObject, 0.25f); 

		}
	}
}
