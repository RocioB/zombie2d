using UnityEngine;
using System.Collections;

public class bala : MonoBehaviour {
	public Vector2 velocity = new Vector2(5,0);
	public GameObject particulas;
	// Use this for initialization
	void Start () {
		rigidbody2D.AddForce (velocity * transform.localScale.x, ForceMode2D.Impulse);
	}

		void OnCollisionEnter2D(Collision2D target) {
		onDestroy ();
	}

	void onDestroy () {
		var clone = Instantiate (particulas, transform.position, Quaternion.identity)
			as GameObject;
		Destroy (clone, 1);

		}
	

}
