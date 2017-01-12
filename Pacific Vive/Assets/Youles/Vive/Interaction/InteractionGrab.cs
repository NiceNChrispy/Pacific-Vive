//Chris Youles Vive Controller Interaction Grab Script 
//Date Modified - 12/01/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionGrab : MonoBehaviour {

    [SerializeField]
    private GameObject grabbedObj;

    [SerializeField]
    private ViveController viveController;

    void OnEnable()
    {
        viveController.TriggerActionUp += ReleaseAction;
        viveController.TriggerActionDown += GrabAction;
    }

    void GrabAction()
    {
        grabbedObj = viveController.collidingObject;
        if (grabbedObj.GetComponent<Rigidbody>())
        {
            viveController.collidingObject = null;
            FixedJoint joint = AddFixedJoint();
            joint.connectedBody = grabbedObj.GetComponent<Rigidbody>();
        }
    }

    private FixedJoint AddFixedJoint()
    {
        FixedJoint fixedJoint = gameObject.AddComponent<FixedJoint>();
        fixedJoint.breakForce = 20000;
        fixedJoint.breakTorque = 20000;
        return fixedJoint;
    }

    private void ReleaseAction()
    {
        if (GetComponent<FixedJoint>())
        {
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy(GetComponent<FixedJoint>());
            grabbedObj.GetComponent<Rigidbody>().velocity = viveController.GetComponent<Rigidbody>().velocity;
            grabbedObj.GetComponent<Rigidbody>().angularVelocity = viveController.GetComponent<Rigidbody>().angularVelocity;
        }
        grabbedObj = null;
    }
}
