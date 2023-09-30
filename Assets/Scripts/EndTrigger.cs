using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameObject hatch;
    [SerializeField] GameObject boyfriend; // i love game dev
    [SerializeField] Sprite bfNewSprite;

    void OnTriggerEnter2D(Collider2D collision)
    {
        HeadController player = collision.GetComponent<HeadController>();
        if (player != null)
        {
            boyfriend.GetComponent<SpriteRenderer>().sprite = bfNewSprite;
            Destroy(hatch);
        }
    }
}
