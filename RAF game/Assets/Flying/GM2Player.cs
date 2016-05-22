using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GM2Player : MonoBehaviour {

	public Vector3 jumpForce = new Vector3 (0,300,0);  
	public Rigidbody rb;

	public Text scoreText; 
	public static int playerScore = 0; 
	public static int playerFaults = 0; 

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		scoreText.text = "Score: " + playerScore.ToString (); 

		if (Input.GetKeyUp("space") || (Input.GetMouseButtonDown(0))){

			rb.velocity = new Vector3 (0,0,0); 
			rb.AddForce(jumpForce); 

		}
	}

	void OnTriggerExit (Collider Col){
		if (Col.gameObject.name == ("Rings(Clone)")){
			playerScore += 1; 
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == ("Bottom") || (other.gameObject.name == ("TOP"))) {
			transform.position = new Vector3(1.3047f,2.2112f,-4.4839f);
			playerFaults +=1; 

		}
	}

	void OnCollisionEnter (Collision Col){
		if (Col.transform.FindChild("Sphere001") || (Col.transform.FindChild ("Sphere002"))) {
			Destroy(Col.gameObject); 
			playerFaults +=1; 
		}
	}


}
