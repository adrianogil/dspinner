using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour {

    private Camera camera;

    [Range(0f,1f)]
    public float fakeLerpFactor;

    public Color colorA, colorB;

	// Use this for initialization
	void Start () {
		
        camera = Camera.main;

	}
	
	// Update is called once per frame
	void Update () {
		
        #if UNITY_EDITOR
        camera.backgroundColor = Color.Lerp(colorA, colorB, fakeLerpFactor);
        #elif UNITY_ANDROID
        fakeLerpFactor = Mathf.Abs(0.5f*Input.acceleration.y);
        camera.backgroundColor = Color.Lerp(colorA, colorB, fakeLerpFactor);
        #endif
	}
}
