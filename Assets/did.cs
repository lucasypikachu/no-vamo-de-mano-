using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class did : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(transform.localScale.x / transform.parent.localScale.x, transform.localScale.y / transform.parent.localScale.y, transform.localScale.z / transform.parent.localScale.z);
        Destroy(gameObject,0.2f);
    }

}
