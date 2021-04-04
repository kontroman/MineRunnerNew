using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostersData : MonoBehaviour
{   
    public static BoostersData Instance { get; private set; }
    
    #region vars
    [SerializeField] private int priceBooster1;
    [SerializeField] private int priceBooster2;
    [SerializeField] private int priceBooster3;
    [SerializeField] private int priceBooster4;

    private int countBooster1;
    private int countBooster2;
    private int countBooster3;
    private int countBooster4;

    public int PriceBooster1 { get { return priceBooster1; } }
    public int PriceBooster2 { get { return priceBooster2; } }
    public int PriceBooster3 { get { return priceBooster3; } }
    public int PriceBooster4 { get { return priceBooster4; } }

    public int CountBooster1 { get { return countBooster1; } }
    public int CountBooster2 { get { return countBooster2; } }
    public int CountBooster3 { get { return countBooster3; } }
    public int CountBooster4 { get { return countBooster4; } }

    #endregion

    void Awake()
    {
        if (Instance != null) return;
        else Instance = this;

        Init();
    }

    public void Init()
    {
        LoadBoostersData();
    }

    public void LoadBoostersData()
    {
        PlayerPrefs.GetInt("CountBooster1", 0);
        PlayerPrefs.GetInt("CountBooster2", 0);
        PlayerPrefs.GetInt("CountBooster3", 0);
        PlayerPrefs.GetInt("CountBooster4", 0);
    }

    public void SaveBoostersData()
    {
        PlayerPrefs.SetInt("CountBooster1", CountBooster1);
        PlayerPrefs.SetInt("CountBooster2", CountBooster2);
        PlayerPrefs.SetInt("CountBooster3", CountBooster3);
        PlayerPrefs.SetInt("CountBooster4", CountBooster4);
    }
}
