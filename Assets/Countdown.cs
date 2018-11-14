using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Countdown : MonoBehaviour
{
    public Text timerText;
    void Start()
    {
        StartCoroutine(TimerTick());
    }
    IEnumerator TimerTick()
    {
        GameVaraibles.currentTime = GameVaraibles.allowedTime;
        while (GameVaraibles.currentTime > 0)
        {
            //attendre	1	seconde
            yield return new WaitForSeconds(1.0f);
            GameVaraibles.currentTime--;
            timerText.text = "Time	:" + GameVaraibles.currentTime;
        }
        //	game	over	and	restart
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
