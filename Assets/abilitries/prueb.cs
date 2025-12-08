using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.WSA;

[CreateAssetMenu]
public class prueb : enemies
{
    //crea una pelota
    public GameObject sus;
   public override void wuw(GameObject launcher, float anglo)
    { 
        Instantiate(sus, launcher.transform.position, launcher.transform.rotation);

    }
}
