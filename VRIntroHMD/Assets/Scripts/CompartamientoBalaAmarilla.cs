using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompartamientoBalaAmarilla : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BalaAmarilla" && collision.gameObject.name == "Bala(Clone)")
            Destroy(this.gameObject);
    }





}
