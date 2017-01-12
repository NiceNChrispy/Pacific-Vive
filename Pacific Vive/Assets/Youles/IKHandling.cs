using UnityEngine;
using System.Collections;

public class IKHandling : MonoBehaviour {

    Animator anim;

    public float IKWeight = 1;

    public Transform leftIKTargetHand;
    public Transform rightIKTargetHand;
    public Transform hintLeftKnee;
    public Transform hintRightKnee;
    public Transform leftIKTargetFoot;
    public Transform rightIKTargetFoot;
    public Transform hintLeftElbow;
    public Transform hintRightElbow;


    // Use this for initialization
    void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnAnimatorIK()
    {
        //Feet
        //Sets Left foot position and weight
        anim.SetIKPositionWeight(AvatarIKGoal.LeftFoot, IKWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.LeftFoot, IKWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftFoot, leftIKTargetFoot.position);
        anim.SetIKRotation(AvatarIKGoal.LeftFoot, leftIKTargetFoot.rotation);

        // Sets right foot position and weight
        anim.SetIKPositionWeight(AvatarIKGoal.RightFoot, IKWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.RightFoot, IKWeight);
        anim.SetIKPosition(AvatarIKGoal.RightFoot, rightIKTargetFoot.position);
        anim.SetIKRotation(AvatarIKGoal.RightFoot, rightIKTargetFoot.rotation);

        //#############################################################################

        //Knees
        //Left
        anim.SetIKHintPositionWeight(AvatarIKHint.LeftKnee, IKWeight);
        anim.SetIKHintPosition(AvatarIKHint.LeftKnee, hintLeftKnee.position);

        //Right
        anim.SetIKHintPositionWeight(AvatarIKHint.RightKnee, IKWeight);
        anim.SetIKHintPosition(AvatarIKHint.RightKnee, hintRightKnee.position);

        //#############################################################################

        //Hands
        //Left
        anim.SetIKPositionWeight(AvatarIKGoal.LeftHand, IKWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.LeftHand, IKWeight);
        anim.SetIKPosition(AvatarIKGoal.LeftHand, leftIKTargetHand.position);
        anim.SetIKRotation(AvatarIKGoal.LeftHand, leftIKTargetHand.rotation);

        //Right
        anim.SetIKPositionWeight(AvatarIKGoal.RightHand, IKWeight);
        anim.SetIKRotationWeight(AvatarIKGoal.RightHand, IKWeight);
        anim.SetIKPosition(AvatarIKGoal.RightHand, rightIKTargetHand.position);
        anim.SetIKRotation(AvatarIKGoal.RightHand, rightIKTargetHand.rotation);

        //#############################################################################

        //Elbows
        //Left
        anim.SetIKHintPositionWeight(AvatarIKHint.LeftElbow, IKWeight);
        anim.SetIKHintPosition(AvatarIKHint.LeftElbow, hintLeftElbow.position);

        //Right
        anim.SetIKHintPositionWeight(AvatarIKHint.RightElbow, IKWeight);
        anim.SetIKHintPosition(AvatarIKHint.RightElbow, hintRightElbow.position);
        

        //#############################################################################
    }
}
