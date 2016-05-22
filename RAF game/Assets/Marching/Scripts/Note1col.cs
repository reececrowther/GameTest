using UnityEngine;
using System.Collections;

public class Note1col : MonoBehaviour {

	public static string destroyNote1 = "NO";
	

	void OnTriggerStay (Collider Col){
		
		if ((Input.GetMouseButton (0)) && (Col.gameObject.name == "note1(Clone)")) {
			destroyNote1 = "Yes";
			Debug.Log("col"); 
		}


	}


}
