using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SongControl : MonoBehaviour {

	public List<float> noteSelection = new List<float>() {1,4,6,9,11,14,16,18,21,23,25,28};

	
	public int Marker = 0; 

	public Transform Note1; 
	public Transform Note2; 
	public Transform Note3; 

	public float LengthOfSong=0; 
	


	public Text ScoreText; 
	public static int Score = 0;

	public Text multiplierText; 
	public static int multiplierScore = 0; 



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		LengthOfSong += Time.deltaTime; 

		ScoreText.text = "Score: " + Score.ToString (); 
		multiplierText.text = "Multiplier: x" + multiplierScore.ToString (); 

		if ((LengthOfSong>= noteSelection [Marker]) && (LengthOfSong<= noteSelection [Marker] + 0.125)){

			if (Marker == 0 || Marker == 4 || Marker == 7 || Marker == 9){

				Instantiate(Note1,Note1.position,Note1.rotation); 
			}

			if (Marker == 1 || Marker == 3 || Marker == 6 || Marker == 8){
				Instantiate(Note2,Note2.position,Note2.rotation); 
			}

			if (Marker == 2 || Marker == 5 || Marker == 10 || Marker == 12){
				Instantiate(Note3,Note3.position,Note3.rotation); 
			}

				Marker += 1;


	}

	
	}


}
