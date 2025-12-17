using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escuco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x / transform.parent.localScale.x, transform.localScale.y / transform.parent.localScale.y, transform.localScale.z / transform.parent.localScale.z);
        Destroy(gameObject, 0.2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (transform.parent.tag == "Player")
        {
            if (collision.gameObject.tag == "attas")
        {
                grab.comobo(5, 3);
                transform.tag = "attas:(";
            }
        }
        else
        {
            if (collision.gameObject.tag == "attas:(")
            {
                transform.tag = "attas";

            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (transform.parent.tag == "Player")
        {

            if (collision.tag == "attas")
        {

                grab.comobo(5, 3);
                transform.tag = "attas:(";
            }
        }
        else
        {
            if (collision.gameObject.tag == "attas:(")
            {

                transform.tag = "attas";
            }

        }
    }
}
