using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegRotate : MonoBehaviour
{
    [SerializeField] KeyCode leftKey;
    [SerializeField] KeyCode rightKey;
    [SerializeField] float rotForce = 0.5f;

    Rigidbody2D rb;
    float inputValue = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputValue = -BoolToValue(Input.GetKey(leftKey)) + BoolToValue(Input.GetKey(rightKey));

        rb.AddForce(transform.right * inputValue * rotForce, ForceMode2D.Impulse);
    }

    float BoolToValue(bool boolean)
    {
        if (boolean) { return 1f; }
        else { return 0f; }
    }
}
