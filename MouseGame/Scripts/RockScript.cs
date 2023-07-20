using UnityEngine;
using System.Collections;

public class RockScript : MonoBehaviour {
//attach this script to the rock Prefab

	float lifespan = 3.0f; //how long the rock will stay in the game scene

	// Update is called once per frame
	void Update () {
		lifespan -= Time.deltaTime;
		if(lifespan <= 0) {
			Explode();
		}
	}

	//rock will be directly destroyed if it collides with target
	void OnCollisionEnter(Collision collision) {
		if(collision.gameObject.tag == "Target") {
			Destroy(gameObject);			
		}
	}

	//Explode function to destroy rock
	void Explode() {
		Destroy(gameObject);
	}
}
