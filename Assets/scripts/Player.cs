using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public float speed = 10f;
	public Vector2 maxVelocity = new Vector2(2,3);
	private Animator animator;
	
	// Use this for initialization
	void Start () {

		animator = GetComponent <Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		var absVelX = Mathf.Abs (rigidbody2D.velocity.x);
		var forceX = 0f;
		var forceY = 0f;
		
		//Calculate Velocity X
		if (Input.GetKey("right"))
		{
			//Esto lo que hace es frenar cuando voy a la izquierda y pulso la derecha
			if (rigidbody2D.velocity.x < 0) {
				rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
			}

			if(absVelX < maxVelocity.x)
				forceX = speed;
			//Esto pone el sprite mirando a la derecha
			this.transform.localScale = new Vector3 (1,1,1);
		}
		else if (Input.GetKey("left"))
		{
			//Esto lo que hace es frenar cuando voy a la derecha y pulso la izquierda
			if (rigidbody2D.velocity.x > 0) {
				rigidbody2D.velocity = new Vector2 (0, rigidbody2D.velocity.y);
			}
				if (absVelX < maxVelocity.x)
				forceX = -speed;
			//Esto pone el script mirando a la izquierda
			this.transform.localScale = new Vector3 (-1,1,1);

		}
		//Actualizamos la variable Velocity cuando la velocidad es mayot de 0
		if (absVelX > 0)
						animator.SetFloat ("velocity", absVelX);

		rigidbody2D.AddForce (new Vector2 (forceX, forceY));


		if (Input.GetKey ("c")) {
						animator.SetBool ("fire", true);

				} else {
						animator.SetBool ("fire", false);
				}


		
		
	}
}