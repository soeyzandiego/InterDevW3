using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegMovement : MonoBehaviour
{
    [SerializeField] float hingeSpeed = 20;
    [SerializeField] float springForce = 10;

    [Header("Physics Components")]
    [SerializeField] HingeJoint2D upperHinge;
    [SerializeField] HingeJoint2D lowerHinge;
    [SerializeField] SpringJoint2D footSpring;

    [Header("Input")]
    [SerializeField] KeyCode upperKey;
    [SerializeField] KeyCode lowerKey;
    [SerializeField] KeyCode springKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(upperKey))
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
        
        if (Input.GetKey(lowerKey))
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

        if (Input.GetKeyDown(springKey))
        {
            footSpring.GetComponent<Rigidbody2D>().AddForce(transform.up * springForce, ForceMode2D.Impulse);
        }
    }
}
