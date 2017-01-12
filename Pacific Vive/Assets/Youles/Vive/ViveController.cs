//Chris Youles Vive Controller Script
//Date Modified - 12/01/2017
using UnityEngine;
using System.Collections;
using System;

public class ViveController : MonoBehaviour {

    private Valve.VR.EVRButtonId gripButton = Valve.VR.EVRButtonId.k_EButton_Grip;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;
    private Valve.VR.EVRButtonId touchPad = Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad;
    private Valve.VR.EVRButtonId touchPadVector = Valve.VR.EVRButtonId.k_EButton_Axis0;


    public event Action GripActionDown;
    public event Action GripActionUp;
    public event Action TriggerActionDown;
    public event Action TriggerActionUp;
    public event Action TouchPadAction;
    public event Action TouchPadActionUp;

    public GameObject collidingObject;

    private GameObject objectInHand;

    private SteamVR_TrackedObject trackedObj;
    [SerializeField] private SteamVR_Controller.Device controller { get { return SteamVR_Controller.Input((int)trackedObj.index); } }


    // Use this for initialization
    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller == null)
        {
            Debug.Log("Controller" + controller.index + "not initialised");
            return;
        }

        if (controller.GetAxis() != Vector2.zero)
        {
            Debug.Log(gameObject.name + controller.GetAxis());
        }

        if (controller.GetPressDown(gripButton))
        {
            if(GripActionDown != null)
            GripActionDown();
        }
        
        if (controller.GetPressUp(gripButton))
        {
            if(GripActionUp != null)
            GripActionUp();
        }

        if (controller.GetPressDown(triggerButton))
        {
            if(TriggerActionDown != null)
            TriggerActionDown();
        }

        if (controller.GetPressUp(triggerButton))
        {
            if(TriggerActionUp != null)
            TriggerActionUp();
        }

        if (controller.GetPressDown(touchPad))
        {
            if (TouchPadAction != null)
                TouchPadAction();
        }

        if (controller.GetPressUp(touchPad))
        {
            if (TouchPadActionUp != null)
                TouchPadActionUp();
        }

    }

    void OntriggerEnter(Collider col)
    {
        collidingObject = col.gameObject;
    }

    void OntriggerExit(Collider col)
    {
        collidingObject = null;
    }

    void VibrateController(ushort vibration)
    {
        controller.TriggerHapticPulse(vibration);
    }


}
