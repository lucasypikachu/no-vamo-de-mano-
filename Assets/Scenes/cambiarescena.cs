using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiarescena : MonoBehaviour
{

  public  void inicio()
    {

        var op = SceneManager.LoadSceneAsync("SampleScene", LoadSceneMode.Single);

    }
}
