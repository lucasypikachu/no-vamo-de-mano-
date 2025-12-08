using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class dead : MonoBehaviour
{
    public int heala;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "attas")
        {
            heala--;
        }
        if (heala <= 0)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "attas")
        {
            heala--;
        }
        if (heala <= 0)
        {
            Destroy(gameObject);
        }

    }
}
