using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform targetTransform;
    [SerializeField] Vector3 offset;
    [SerializeField] float smoothValue = 0.01f;

    [Header("Bounds")]
    [SerializeField] float leftBound;
    [SerializeField] float rightBound;


    // Update is called once per frame
    void Update()
    {
        // uhhh swap this to smoothdampen for future
        Vector3 targetPos = new Vector3(targetTransform.position.x, 0, -10);
        targetPos.x = Mathf.Clamp(targetTransform.position.x, leftBound, rightBound);

        Vector3 newPos = Vector3.Lerp(transform.position, targetPos + offset, smoothValue);
        newPos.z = -10;


        transform.position = newPos;
    }
}
