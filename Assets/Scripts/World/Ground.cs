﻿using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	private Player player;

	void Start () {
		player = FindObjectOfType<Player>();
		PolygonCollider2D[] colliders = GetComponentsInChildren<PolygonCollider2D>();
		foreach (PolygonCollider2D collider in colliders) {
			collider.isTrigger = true;
		}
	}

	void OnMouseDown () {
		
		Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		target.z = player.transform.position.z;
		Debug.Log(target);
		player.MovePlayer(target);
	}
}
