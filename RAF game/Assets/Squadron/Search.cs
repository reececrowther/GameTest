using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Search : MonoBehaviour {


	public Image mapImage; 

	public void TextChanged(string newText){
		mapImage.enabled = true; 
	}

	public void backButton(){
		Application.LoadLevel ("Main Menu"); 
	}

}
