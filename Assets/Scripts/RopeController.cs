using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    [SerializeField] Transform attachPoint;
    [SerializeField] Vector3 offset;

    LineRenderer lr;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, attachPoint.position);
    }

    private void OnDrawGizmos()
    {
        if (attachPoint == null) { return; } // so no error thrown when inspector field is empty
        Gizmos.DrawLine(attachPoint.position + offset, transform.position);
    }
}
