using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public enum quest 
{
    BoosterQuest, //Заюзать Х бустеров
    TimeQuest, //Продержаться Х секунд
    ScoreQuest, //Зарабоатать Х очков
    DiamondQuest, // Собрать X алмазов
    RecordQuest // Поставить новый рекорд
}
public class QuestsController : MonoBehaviour
{
    public static QuestsController Instance { get; private set; }

    public Quest actualQuest;
    public string actaulQuestName;
    public float value;
    float _value = 0;

    public int diamondScore;
    public int numberOfBoost;
    public int numberOfDiamond;
    public int time;
    public int score;
    public int record;

    void Update()
    {
        UpdateStats();

    }

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;

        actualQuest = GetNewQuest();
        Debug.Log(actualQuest.QuestName);
        Debug.Log(actualQuest.Target);
        Debug.Log(actualQuest.Prize);
    }

    public Quest GetNewQuest()
    {
        return new Quest(((quest)Random.Range(1, 5)).ToString());
    }

    public void CheckForFinish(float diamondScore, Quest quest, float value)
    {
        if (quest.IsComplete(value))
        {
            diamondScore += quest.Prize * quest.Lvl;
            PlayerPrefs.SetInt(quest.QuestName, (quest.Lvl)++);
            Debug.Log("+");
        }
        else
         Debug.Log('-');
    }

    public float DifineTarget(Quest quest)
    {
        switch (quest.QuestName)
        {
            case "BoosterQuest":
                _value = numberOfBoost;
                break;
            case "TimeQuest":
                _value = time;
                break;
            case "ScoreQuest":
                _value = score;
                break;
            case "DiamondQuest":
                _value = numberOfDiamond;
                break;
            case "RecordQuest":
                _value = record;
                break;
            default:
                break;
        }
        return _value;
    }

    public float UpdateStats()
    {
        return 0;
    }

    public void PlusPlusT()
    {
        time++;
        Debug.Log("time");
        Debug.Log(time);
        CheckForFinish(diamondScore, actualQuest, DifineTarget(actualQuest));
    }

    public void PlusPlusB()
    {
        numberOfBoost++;
        Debug.Log("boost");
        Debug.Log(numberOfBoost);
        CheckForFinish(diamondScore, actualQuest, DifineTarget(actualQuest));
    }

    public void PlusPlusS()
    {
        score++;
        Debug.Log("score");
        Debug.Log(score);
        CheckForFinish(diamondScore, actualQuest, DifineTarget(actualQuest));
    }
    public void PlusPlusD()
    {
        numberOfDiamond++;
        Debug.Log("numberOfDiamond");
        Debug.Log(numberOfDiamond);
        CheckForFinish(diamondScore, actualQuest, DifineTarget(actualQuest));
    }
}