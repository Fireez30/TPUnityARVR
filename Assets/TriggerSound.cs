using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        gameObject.GetComponent<Animator>().SetTrigger("hit");
    }

}
