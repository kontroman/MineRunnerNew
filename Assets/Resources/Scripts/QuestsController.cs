using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class QuestsController : MonoBehaviour
{
    public static QuestsController Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;

        Init();
    }


    private void Init()
    {

    }

    public Quest GetNewQuest()
    {
        return new Quest();
    }
}