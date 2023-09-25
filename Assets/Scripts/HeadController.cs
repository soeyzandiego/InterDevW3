using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    [SerializeField] Sprite defaultSprite;
    [SerializeField] Sprite grabSprite;

    Rigidbody2D rb;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            //rb.freezeRotation = true;
            sprite.sprite = grabSprite;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.None;
            //rb.freezeRotation = false;
            sprite.sprite = defaultSprite;
        }
    }
}
