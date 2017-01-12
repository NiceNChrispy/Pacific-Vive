//Chris Youles Vive Controller Interaction Use Script
//Date Modified - 12/01/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InteractionUse : MonoBehaviour {

    public event Action UseActionTrigger;

    [SerializeField]
    private GameObject grabbedObj;

    [SerializeField]
    private ViveController viveController;



    void OnEnable()
    {
        viveController.GripActionDown += UseAction;
        viveController.GripActionUp += StopAction;
    }

    void UseAction()
    {
        if (UseActionTrigger != null)
        {
            UseActionTrigger();
        }

    }

    void StopAction()
    {
      
    }
}
