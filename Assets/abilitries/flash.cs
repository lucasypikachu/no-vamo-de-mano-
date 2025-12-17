using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class flash : enemies
{
    //dash
    public Rigidbody2D rb;
    public override void wuw(GameObject launcher, float anglo,bool evil)
    {
        float xix = 400 * Mathf.Cos(anglo * Mathf.Deg2Rad);
        float yiy = 400 * Mathf.Sin(anglo * Mathf.Deg2Rad);
        rb = launcher.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(xix, yiy));

    }
}
