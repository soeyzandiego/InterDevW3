using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentController : MonoBehaviour
{

    [SerializeField] Color selectedColor = Color.red;

    [Header("Hinges")]
    [SerializeField] float hingeSpeed = 75f;
    [SerializeField] HingeJoint2D[] segmentHinges;

    int segIndex = 0;
    HingeJoint2D curSegment;

    Color oColor;

    // Start is called before the first frame update
    void Start()
    {
        curSegment = segmentHinges[segIndex];
        oColor = curSegment.GetComponent<SpriteRenderer>().color;
        curSegment.GetComponent<SpriteRenderer>().color = selectedColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow)) { NextSegment(); }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { LastSegment(); }

        if (Input.GetKey(KeyCode.D))
        {
            JointMotor2D curMotor = curSegment.motor;

            curSegment.useMotor = true;
            curMotor.motorSpeed = hingeSpeed;
            curSegment.motor = curMotor;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            JointMotor2D curMotor = curSegment.motor;

            curSegment.useMotor = true;
            curMotor.motorSpeed = -hingeSpeed;
            curSegment.motor = curMotor;
        }
        else
        {
            curSegment.useMotor = false;
        }
    }


    void NextSegment()
    {
        // reset color
        curSegment.GetComponent<SpriteRenderer>().color = oColor;

        if (segIndex < segmentHinges.Length - 1) { segIndex++; }
        else { segIndex = 0; }
        curSegment = segmentHinges[segIndex];
        curSegment.GetComponent<SpriteRenderer>().color = selectedColor;
    }

    void LastSegment()
    {
        // reset color
        curSegment.GetComponent<SpriteRenderer>().color = oColor;

        if (segIndex > 0) { segIndex--; }
        else { segIndex = segmentHinges.Length - 1; }
        curSegment = segmentHinges[segIndex];
        curSegment.GetComponent<SpriteRenderer>().color = selectedColor;
    }
}
