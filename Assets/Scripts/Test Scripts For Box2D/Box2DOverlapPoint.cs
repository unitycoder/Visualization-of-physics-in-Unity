﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityBerserkersGizmos;

[ExecuteInEditMode]
public class Box2DOverlapPoint : MonoBehaviour
{
	[SerializeField]Vector3 point;
	RaycastHit2D hitByRayCast;

	[Space (55)][Header ("Results:")]
	[SerializeField]bool isSomethingOverlapingPoint;

	void Update ()
	{		
		isSomethingOverlapingPoint = Physics2D.OverlapPoint (point: point);
	}

	void OnDrawGizmos ()
	{
		GizmosForPhysics2D.DrawOverlapPoint (point: point);
	}
}
