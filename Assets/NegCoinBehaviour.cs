using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NegCoinBehaviour : MonoBehaviour {
    AudioSource aud;
    bool once = false;
    GameObject world;

    void Update()
    {
        if (once && !aud.isPlaying)
        {
            world.SendMessage("RemoveCoin");
            Destroy(gameObject);
        }
    }
    void Start()
    {
        aud = gameObject.GetComponent<AudioSource>();
        world = GameObject.Find("World");
    }
    void OnTriggerEnter(Collider other)
    {
        // GetComponent<Renderer>().enabled = false;
        if (aud)
        {
            aud.Play();
        }
        once = true;
    }
}
