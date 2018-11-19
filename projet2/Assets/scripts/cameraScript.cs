using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour {
    public Camera mainCamera;
    public Camera TopCamera;
    // Use this for initialization
    void Start () {
        mainCamera.enabled = true;
        TopCamera.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.enabled = !mainCamera.enabled;
            TopCamera.enabled = !TopCamera.enabled;
        }

    }
}
