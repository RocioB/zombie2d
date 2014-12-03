using UnityEngine;
using System.Collections;

public class puertaScript : MonoBehaviour {
	public Transform destino;
	bool delantepuerta = false;
		bool teletransporta = false;

	void OnTriggerEnter2D(Collider2D target) {
		if (target.transform.tag == "Player")
						delantepuerta = true;
	}

	void OnDrawGizmos () {
				if (destino != null) {
						Gizmos.color = Color.blue;
						Gizmos.DrawLine (transform.position, destino.position);
				}
		}
			// Use this for initialization
			

		



	void Update () {
				if (Input.GetKeyDown ("up") && delantepuerta) {
			teletransporta = true;
			}
		}

	void OnTriggerStay2D(Collider2D target) {
						if (teletransporta) {
			target.transform.position=destino.position;
							teletransporta = false;
							delantepuerta = false;
						}
					}


	void OnTriggerExit2D(Collider2D target) {
						if (target.transform.tag == "Player")
							delantepuerta = false;

		}
		}