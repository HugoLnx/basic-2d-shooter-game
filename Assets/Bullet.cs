using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	private const float SPEED = 7f;
	void Update () {
		var pos = this.transform.position;
		this.transform.position = new Vector2 (pos.x+SPEED*Time.deltaTime, pos.y);
	}
}
