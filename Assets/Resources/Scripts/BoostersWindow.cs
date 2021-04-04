using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoostersWindow : MonoBehaviour
{

    public static BoostersWindow Instance { get; private set; }

    [SerializeField] private Text pb1; //price booster
    [SerializeField] private Text pb2; //price booster
    [SerializeField] private Text pb3; //price booster
    [SerializeField] private Text pb4; //price booster

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    private void OnEnable()
    {
        Init();
    }

    public void Init()
    {
        pb1.text = "" + BoostersData.Instance.PriceBooster1;
        //pb2.text = "" + BoostersData.Instance.PriceBooster2;
        //pb3.text = "" + BoostersData.Instance.PriceBooster3;
        //pb4.text = "" + BoostersData.Instance.PriceBooster4;
    }

    public void BuyBooster()
    {

    }
}
