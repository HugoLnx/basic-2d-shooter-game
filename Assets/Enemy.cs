using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private float speed = 2;
	private float initialY;
	private float amplitude;
	private float bouncingSpeed;

	void Start() {
		initialY = this.transform.position.y;
		amplitude = Random.Range (0.1f,0.6f);
		bouncingSpeed = Random.Range (3f,7f);
	}

	void Update () {
		var pos = this.transform.position;
		this.transform.position = new Vector2 (pos.x-speed*Time.deltaTime, initialY + Mathf.Sin(Time.fixedTime*bouncingSpeed)*amplitude);
	}

	void OnTriggerEnter2D(Collider2D collider) {
		if (collider.gameObject.tag == "Bullet") {
			Destroy (collider.gameObject);
			Destroy (this.gameObject);
		}
	}
}
