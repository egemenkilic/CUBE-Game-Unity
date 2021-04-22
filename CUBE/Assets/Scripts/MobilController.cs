using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilController : MonoBehaviour
{
    public GameObject Player;
    public Rigidbody rb;
    public float sidewaysForce = 500f;

    public void Right()
    {
        rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    
    public void Left()
    {
        rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}
