﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerScript3D : MonoBehaviour
{

	public SimpleWorldGen generator;

	void Start ()
	{
//		generator = (SimpleWorldGen)GameObject.Find ("World Generator");
	}

	void Update ()
	{
	}

	void OnTriggerEnter (Collider other)
	{
		SimpleWorldGen.triggerWorldUpdate = true;
		SimpleWorldGen.currentTile = gameObject.transform;
	}

	void OnTriggerStay (Collider other)
	{
	}

	void OnTriggerExit (Collider other)
	{
	}
}
