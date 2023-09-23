using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegSpring : MonoBehaviour
{
    [SerializeField] float inputForce = 150f;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * inputForce, ForceMode2D.Impulse);
        }
    }
}
