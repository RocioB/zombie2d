using UnityEngine;
using System.Collections;

public class nextLevel : MonoBehaviour {

	public string nombreNivel;
	bool cargando=false;
		public float tiempoEspera=3f;

	void OnTriggerStay2D (Collider2D target) {

				if (target.transform.tag == "Player") {
						if (!cargando) {
				StartCoroutine(cargaNivel());
		}
		}
	}

	// Use this for initialization



	void OnTriggerExit2D(Collider2D target) {
				cargando = false;
		}


	IEnumerator cargaNivel () {
		cargando=true;
		yield return new WaitForSeconds(tiempoEspera);
		if(cargando)
			Application.LoadLevel(nombreNivel);
	}
}
