using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onhit : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
            other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-500f, 500f), Random.Range(-500f, 500f)));
    }
}
