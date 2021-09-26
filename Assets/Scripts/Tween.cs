using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween 
{
    public Transform Target { get; protected set; }
    public Vector3 StartPos { get; protected set; }
    public Vector3 EndPos { get; protected set; }
    public float StartTime { get; protected set; }
    public float Duration { get; protected set; }

    public Tween(Transform gameObject, Vector3 startPos, Vector3 endPos, float startTime, float duration)
    {
        Target = gameObject;
        StartPos = startPos;
        EndPos = endPos;
        StartTime = startTime;
        Duration = duration;
	}

}
