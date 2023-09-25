using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovement : MonoBehaviour
{
    [SerializeField] float hingeSpeed = 50f;
     
    [SerializeField] HingeJoint2D upperHinge;
    [SerializeField] HingeJoint2D lowerHinge;

    [Header("Upper Hinge Controls")]
    [SerializeField] KeyCode upLeftKey;
    [SerializeField] KeyCode upRightKey;

    [Header("Lower Hinge Controls")]
    [SerializeField] KeyCode lowLeftKey;
    [SerializeField] KeyCode lowRightKey;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upLeftKey))
        {
            JointMotor2D motor = upperHinge.motor;

            upperHinge.useMotor = true;
            motor.motorSpeed = hingeSpeed;
            upperHinge.motor = motor;
        }
        else if (Input.GetKey(upRightKey))
        {
            JointMotor2D motor = upperHinge.motor;

            upperHinge.useMotor = true;
            motor.motorSpeed = -hingeSpeed;
            upperHinge.motor = motor;
        }
        else
        {
            upperHinge.useMotor = false;
        }

        if (Input.GetKey(lowLeftKey))
        {
            JointMotor2D motor = lowerHinge.motor;

            lowerHinge.useMotor = true;
            motor.motorSpeed = hingeSpeed;
            lowerHinge.motor = motor;
        }
        else if (Input.GetKey(lowRightKey))
        {
            JointMotor2D motor = lowerHinge.motor;

            lowerHinge.useMotor = true;
            motor.motorSpeed = -hingeSpeed;
            lowerHinge.motor = motor;
        }
        else
        {
            lowerHinge.useMotor = false;
        }
    }
}
