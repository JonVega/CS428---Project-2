using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour
{
	public GameObject vbBtnObj;
	public Animator cubeAni;
	
    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("btn");
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
		vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
		//cubeAni.GetComponent<Animator>();
    }

	public void OnButtonPressed(VirtualButtonBehaviour vb) {
		Debug.Log("Button Pressed");
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb) {
		Debug.Log("Button Released");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
