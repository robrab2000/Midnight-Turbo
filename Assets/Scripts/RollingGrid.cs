﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using InControl;

public class RollingGrid : MonoBehaviour {

public float throttle;

	[Range(0,1)]
	public float scrollSpeed = 0.5F;
    public Renderer rend;
    void Start() {
        rend = GetComponent<Renderer>();
    }
    void Update() {

			// Use last device which provided input.
			var inputDevice = InputManager.ActiveDevice;
            //print(inputDevice.RightTrigger.Value);

        float offset = rend.material.mainTextureOffset.y + Time.deltaTime * Utils.ofMap(GameManager.Instance.FlowRate, 0f, 1f, 0.05f, 0.5f);
        rend.material.mainTextureOffset = new Vector2(0, offset);
    }
}
