using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quest
{
    public float Target = 1;
    public int Lvl = 1;
    public int Prize = 1;

    public string QuestName;

    public Quest(string _questName)
    {
        QuestName = _questName;
        Target = PlayerPrefs.GetInt(QuestName + "Target", 10);
        Lvl = PlayerPrefs.GetInt(QuestName + "Lvl", 1);
        Prize = PlayerPrefs.GetInt(QuestName + "Prize", 10);
    }

    public bool IsComplete(float amount)
    {
        return amount >= this.Target * this.Lvl;
    }

}
