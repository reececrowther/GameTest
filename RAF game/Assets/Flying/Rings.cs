using UnityEngine;
using System.Collections;

public class Rings : MonoBehaviour {

	public Vector3 velocity = new Vector3 (-4,0,0); 
	public float range = 6; 
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = velocity; 
		transform.position = new Vector3 (transform.position.x, transform.position.y - range * Random.value, transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= - 10.5f)
		{
			Destroy (gameObject); 
		}
	}



}
