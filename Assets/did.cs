using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class did : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x / transform.parent.localScale.x, transform.localScale.y / transform.parent.localScale.y, transform.localScale.z / transform.parent.localScale.z);
        Destroy(gameObject,0.2f);
        if (transform.parent.tag == "Player")
        {
            transform.tag = "attas:(";
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "mon")
        {
            if (transform.parent.tag == "Player")
            {
                grab.comobo(1,1);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "mon")
        {
            if (transform.parent.tag == "Player")
            {

                grab.comobo(1, 1);
            }
        }
    }


}
