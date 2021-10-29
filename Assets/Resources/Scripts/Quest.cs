using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quest
{
    public float Target;
    public int Lvl;
    public int Prize;
    public string QuestName;
    public string Text;

    public Quest(string questName)
    {
        QuestName = questName;
        Lvl = PlayerPrefs.GetInt(QuestName + "Lvl", 1);
        Prize = PlayerPrefs.GetInt(QuestName + "Prize", 10);
        switch (questName)
        {
            case "BoosterQuest":
                Target = PlayerPrefs.GetInt(QuestName + "Target", 2);
                Text = PlayerPrefs.GetString(QuestName + "Text", "Собери " + (this.Lvl * this.Target) + " усилений");
                break;
            case "TimeQuest":
                Target = PlayerPrefs.GetInt(QuestName + "Target", 60);
                Text = PlayerPrefs.GetString(QuestName + "Text", "Продержись " + (this.Lvl * this.Target) + " секунд");
                break;
            case "ScoreQuest":
                Target = PlayerPrefs.GetInt(QuestName + "Target", 1000);
                Text = PlayerPrefs.GetString(QuestName + "Text", "Набери " + (this.Lvl * this.Target) + " очков");
                break;
            case "DiamondQuest":
                Target = PlayerPrefs.GetInt(QuestName + "Target", 100);
                Text = PlayerPrefs.GetString(QuestName + "Text", "Собери " + (this.Lvl * this.Target) + " алмазов");
                break;
            case "RecordQuest":
                Target = PlayerPrefs.GetInt(QuestName + "Target", 10);
                Text = PlayerPrefs.GetString(QuestName + "Text", "Установи новый рекорд");
                break;
            default:
                break;
        }
    }

    public bool IsComplete(float amount)
    {
        return amount >= this.Target * this.Lvl;
    }

}
