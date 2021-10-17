using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quest
{
    private int prevTarget;
    private int currentTarget;
    private int step;

    public string questName;

    public Quest()
    {
        prevTarget = PlayerPrefs.GetInt(questName, 0);
        step = PlayerPrefs.GetInt(questName + step, 0);
        currentTarget = prevTarget + step;
    }

    public bool IsComplete(int amount)
    {
        return amount >= currentTarget;
    }

}