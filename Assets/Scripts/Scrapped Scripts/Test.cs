using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] Rigidbody2D head;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HingeJoint2D joint = GetComponent<HingeJoint2D>();

        if (Input.GetKey(KeyCode.Space))
        {
            JointMotor2D motor = joint.motor;

            joint.useMotor = true;
            motor.motorSpeed = 75;
            joint.motor = motor;

            head.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else
        {
            joint.useMotor = false;
            head.constraints = RigidbodyConstraints2D.None;
        }
    }
}
