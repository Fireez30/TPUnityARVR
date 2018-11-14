using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GiveSword : MonoBehaviour
{

    float distance = 10;
    GameObject player;
    //	Use	this	for	initialization
    void Start()
    {
        player = GameObject.FindWithTag("Player");      //	pour	trouver	le	personnage
    }
    //	Update	is	called	once	per	frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.transform.position);
        if (distance < 3)
        {
            this.transform.parent = player.transform;
            this.transform.localPosition = new Vector3(0.05f, 1.0f, 0.0f);
            this.transform.localRotation = Quaternion.identity;
            this.transform.localRotation = Quaternion.Euler(110, 180, 90);

            //switch to cake launcher scene
            SceneManager.LoadScene(2);
        }
    }
}
