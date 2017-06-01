﻿using UnityEngine;

public class CameraController : MonoBehaviour
{

	public GameObject player;

	private Vector3 offset;

	public void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	public void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}
