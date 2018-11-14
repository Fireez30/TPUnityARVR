using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {


    AudioSource aud;
    bool once = false;
    GameObject world;

    void Update()
    {
        if (once && !aud.isPlaying)
        {
            world.SendMessage("AddCoin");
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
