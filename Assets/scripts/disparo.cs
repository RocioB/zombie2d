using UnityEngine;
using System.Collections;

public class disparo : MonoBehaviour {



	public GameObject bala;
	public Transform puntoDeDisparo;


	public void fire () {
		if (bala != null) {
			var clone = Instantiate(bala, puntoDeDisparo.position,
			                        Quaternion.identity) as GameObject;
			clone.transform.localScale = transform.localScale;
				} else {
			Debug.Log ("Sin balas") ;
	}
}
}