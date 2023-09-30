using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadController : MonoBehaviour
{
    [SerializeField] Sprite defaultSprite;
    [SerializeField] Sprite grabSprite;

    Rigidbody2D rb;
    SpriteRenderer sprite;

    bool touching;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && touching)
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            sprite.sprite = grabSprite;
        }
        else
        {
            rb.constraints = RigidbodyConstraints2D.None;
            sprite.sprite = defaultSprite;
        }
    }

    void FixedUpdate()
    {
        touching = GetComponent<Collider2D>().IsTouchingLayers(LayerMask.GetMask("Ground"));
    }
}
