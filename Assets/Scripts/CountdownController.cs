using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisp;
    private logicScript logic;

    private void Start()
    {
        Time.timeScale = 0f;
        StartCoroutine(CountdownToStart());
    }

    IEnumerator CountdownToStart()
    {
        while (countdownTime > 0)
        {
            countdownDisp.text = countdownTime.ToString();

            yield return new WaitForSecondsRealtime(1f);
            countdownTime--; 
        }

        countdownDisp.text = "FLAP!";

        Time.timeScale = 1f;

        yield return new WaitForSecondsRealtime(1f);
        
        
        countdownDisp.gameObject.SetActive(false);
        
    }
}
