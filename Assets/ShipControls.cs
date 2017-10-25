using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour {

	public GameObject bulletPrefab;
	public GameObject enemyPrefab;
	private float waiting = 0f;
	private float waitingLimit = 0f;

	void Update () {
		var horizontalInput = Input.GetAxis ("Horizontal");
		var verticalInput = Input.GetAxis ("Vertical");

		var pos = this.transform.position;
		var dt = Time.deltaTime;
		this.transform.position = new Vector2 (pos.x + horizontalInput*dt*2, pos.y + verticalInput*dt*2);

		if (Input.GetButtonDown ("Jump")) {
			var bullet = Instantiate (bulletPrefab);
			bullet.transform.position = this.transform.position;
		}

		if (waiting >= waitingLimit) {
			var enemy = Instantiate (enemyPrefab);
			enemy.transform.position = new Vector2 (3.5f, Random.Range(-0.8f, 0.8f));
			waiting = 0f;
			waitingLimit = Random.Range (0.1f, 0.5f);
		}
		waiting += Time.deltaTime;
	}
}
