using UnityEngine;
using System.Collections;

public class Note2Col : MonoBehaviour {

	public static string destroyNote2 = "NO";
	
	
	void OnTriggerStay (Collider Col){
		
		if ((Input.GetMouseButton (0)) && (Col.gameObject.name == "note2(Clone)")) {
			destroyNote2 = "Yes";
		}
		
		
	}

}
