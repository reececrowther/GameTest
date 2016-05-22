using UnityEngine;
using System.Collections;

public class Note3Col : MonoBehaviour {

	public static string destroyNote3 = "NO";
	
	
	void OnTriggerStay (Collider Col){
		
		if ((Input.GetMouseButton (0)) && (Col.gameObject.name == "note3(Clone)")) {
			destroyNote3 = "Yes";
		}
		
		
	}
}
