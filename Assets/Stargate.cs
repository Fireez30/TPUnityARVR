using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Stargate : MonoBehaviour
{
    string levelToLoad = "BoxBoy";
    void OnTriggerEnter(Collider other)
    {
        if (GameVaraibles.coins == GameVaraibles.coinsGoal)
                SceneManager.LoadScene("BoxBoy");
    }
}
