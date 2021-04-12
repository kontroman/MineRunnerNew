using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CD_BeforeResumeGame : MonoBehaviour
{
    public static CD_BeforeResumeGame Instance { get; private set; }

    public GameObject timer;

    public int CD = 3;
    public Text timerText;

    private void Start()
    {
        timerText = GameObject.Find("timer").GetComponent<Text>();
    }
    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    public IEnumerator CountDown(int CD)
    {
        timer.SetActive(true);
        for (int i = CD; i != 0; i--)
            { 
                yield return new WaitForSeconds(1);
                timerText.text = i.ToString();
            }
        timer.SetActive(false);
        Time.timeScale = 1;
    }

    public void SrartCountDownSooooka()
    {
        StartCoroutine(CountDown(CD));
    }
}
