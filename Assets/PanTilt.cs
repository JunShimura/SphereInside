using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanTilt : MonoBehaviour
{
    [SerializeField]
    float rotateAngle = 0.25f;
    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(0, Input.GetAxis("Horizontal") * rotateAngle, 0, Space.World);
        gameObject.transform.Rotate( -Input.GetAxis("Vertical") * rotateAngle, 0,0);


    }
}
