using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abils : MonoBehaviour
{
    //mantener abilidad enemigo
    public enemies sis;
    public float time;
    public float momos;
    // Start is called before the first frame update
    void Start()
    {
        momos = 0f;
        
    }

    // Update is called once per frame
    void Update()
    {
        momos += Time.deltaTime;
        if (momos >= time) 
        {
            sis.wuw(this.gameObject, Random.Range(1, 361),true);
            momos = 0f;
        
        }
        
    }
}
