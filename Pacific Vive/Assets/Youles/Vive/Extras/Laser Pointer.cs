//Chris Youles Vive Controller Laser Pointer Script
//Date Modified - 12/01/2017
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserPointer : MonoBehaviour {

    LineRenderer laserPointerBeam;

    private Vector3 hitPoint;

    [SerializeField]
    private GameObject laserStartPoint;

    [SerializeField]
    private ViveController viveController;

    void OnEnable()
    {
        viveController.TouchPadAction += LaserAction;
        viveController.TouchPadActionUp += LaserActionUp;
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {

        laserPointerBeam.SetPosition(1, hitPoint);
	}

    void LaserAction()
    {
        RaycastHit hit;
        if (Physics.Raycast(laserStartPoint.transform.position, transform.forward, out hit, 100)) ;
        {
            hitPoint = hit.point;
            laserPointerBeam.enabled = true;
        }
    }

    void LaserActionUp()
    {

    }
}
