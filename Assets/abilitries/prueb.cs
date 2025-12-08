using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class prueb : enemies
{
    //crea una pelota
    public GameObject sus;
   public override int wuw(GameObject launcher, float anglo)
    { 
        Instantiate(sus, launcher.transform.position, launcher.transform.rotation);
        return 0;
    }
}
