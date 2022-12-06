using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meyvehareket : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float lifeTime;

    void Start()
    {
        rb.velocity = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));
        Destroy(gameObject, lifeTime);
    }
}
