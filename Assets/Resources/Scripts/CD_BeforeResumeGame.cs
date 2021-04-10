using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CD_BeforeResumeGame : MonoBehaviour
{
    public static CD_BeforeResumeGame Instance { get; private set; }

    private void Start()
    {
        StartCoroutine(CountDown());
    }
    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    public IEnumerator CountDown()
    {
        yield return new WaitForSeconds(3);
        Time.timeScale = 1f;
    }
}
