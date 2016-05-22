using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GenerateRings : MonoBehaviour {

	public GameObject rings; 
	public float overallTime; 
	public Image pauseImage; 
	public Text TextCounter; 

	public Text rankingText; 
	public Text gameoverText; 

	public Button replayButton; 
	public Button quitButton; 
	public Text replayText; 
	public Image replayImage; 
	public Text quitText;
	public Image quitImage; 

	public Text Rank1; 
	public Text Rank2; 
	public Text Rank3; 
	public Text Rank4; 
	public Text Rank5; 
	public Text Rank6; 


	// Use this for initialization
	void Start () {

		InvokeRepeating ("Generation", 1, 1.5f);
		Time.timeScale = 1;
		Player.playerScore = 0; 
	
	}

	void Generation(){
		Instantiate (rings); 
	}
	
	// Update is called once per frame
	void Update () {

		overallTime += Time.deltaTime; 

		TextCounter.text = "Time: " + overallTime.ToString (); 



		if (overallTime >= 20) {
			pauseImage.enabled = true; 
			rankingText.enabled = true; 
			gameoverText.enabled = true; 
			replayButton.enabled = true; 
			quitButton.enabled = true; 
			replayText.enabled = true; 
			replayImage.enabled = true;
			quitText.enabled = true;
			quitImage.enabled = true;
			Time.timeScale = 0; 
			overallTime =0; 

			if (Player.playerScore <= 2){
				Rank1.enabled = true; 
			}
			if (Player.playerScore == 3 || Player.playerScore == 4){
				Rank2.enabled = true; 
			}
			if (Player.playerScore == 5 || Player.playerScore == 6){
				Rank3.enabled = true; 
			}
			if (Player.playerScore == 7 || Player.playerScore == 8){
				Rank4.enabled = true; 
			}
			if (Player.playerScore == 9 || Player.playerScore == 10){
				Rank5.enabled = true; 
			}
			if (Player.playerScore > 10){
				Rank6.enabled = true; 
			}
		}
	
	}
	public void Replay(){
		pauseImage.enabled = false; 
		rankingText.enabled = false; 
		gameoverText.enabled = false; 
		replayButton.enabled = false; 
		quitButton.enabled = false; 
		replayText.enabled = false; 
		replayImage.enabled = false;
		quitText.enabled = false;
		quitImage.enabled = false;
		Application.LoadLevel (Application.loadedLevel); 
		
		Time.timeScale = 1; 
	}
	
	public void Quit(){
		Application.LoadLevel ("Did You Know Flying"); 
	}
}
