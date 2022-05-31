using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRota : MonoBehaviour
{
    void Update()
    {
        Quaternion q = this.transform.rotation;

        this.transform.rotation = q * Quaternion.AngleAxis(2, Vector3.up);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
