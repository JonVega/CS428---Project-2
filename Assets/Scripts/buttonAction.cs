using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonAction : MonoBehaviour
{
	public GameObject vbBtnObj;
	public AudioSource voiceObject;
	
	
    // Start is called before the first frame update
    void Start()
    {
		vbBtnObj = GameObject.Find("button");
		voiceObject = GetComponent<AudioSource>(); vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        Debug.Log("start");
		
    }
	
	public void OnButtonPressed(VirtualButtonBehaviour vb)
	{
	         Debug.Log("Button pressed");
			 voiceObject.Play();
	}
	public void OnButtonReleased(VirtualButtonBehaviour vb)
	{
	         Debug.Log("Button released");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
