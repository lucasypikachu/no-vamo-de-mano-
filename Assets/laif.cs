using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.PlayerSettings;

public class laif : MonoBehaviour
{
    public Text leaf;
    void Update()
    {

        transform.localScale = new Vector2(grab.tiempos * 2f, 0.6f);
        leaf.text = "combo " + grab.combo.ToString();

    }
}
