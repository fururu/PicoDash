using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	Rigidbody2D objectRb;
	public float upForce;
	Transform objectTf;
	
	void Awake () {
		objectRb = GetComponent<Rigidbody2D> ();
		objectTf = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	//&& ((transform.position.y - hitInfo.transform.position.y) < 0.5f)
	void Update () {
		RaycastHit2D hitInfo = Physics2D.Raycast (objectTf.position,Vector2.down);
		if (Input.GetButtonDown("Fire1")) {
			Debug.Log("OK");
			Jump ();
		}
	}
	/*void Jump (){
		objectRb.AddForce (Vector2.up * upForce);
		objectRb.AddForce (new Vector2(0.0f,3.0f));
	}*/
	void Jump () {
		objectRb.velocity = new Vector2(0.0f, upForce);
	}
}	
