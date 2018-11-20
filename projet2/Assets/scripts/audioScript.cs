using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour {

    public AudioSource soundEffect;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PrintFloat()
    {
        Debug.Log("PrintFloat is called with a value of ");
        soundEffect.Play();
    }
}
