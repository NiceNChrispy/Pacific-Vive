using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ToolTips : MonoBehaviour {

    public Transform controller;
    public Transform touchpad;
    public Transform gripButtons;
    public Transform trigger;
    public string touchpadToolTip;
    public string triggerTooltip;
    public string gripTooltip;


    GUIContent touchpadContent;
    GUIContent triggerContent;
    GUIContent gripContent;

    // Use this for initialization
    void Start ()
    {
        touchpadContent = new GUIContent("Touchpad", touchpadToolTip);
        triggerContent = new GUIContent("Trigger", triggerTooltip);
        gripContent = new GUIContent("Grip Button", gripTooltip);


    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void OnGUI()
    {
        GUI.Box(new Rect(0, 0, Screen.width, Screen.height), triggerContent);
        
    }
}
