using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Economy : MonoBehaviour
{
    public static Economy Instance { get; private set; }

    private int diamonds;

    public int Diamonds { get { return diamonds; } }

    private void Awake()
    {
        if (Instance != null) return;
        else Instance = this;
    }

    public void Buy(int _price)
    {
        diamonds -= _price;
    }

    public void Add(int _count)
    {
        diamonds += _count;
    }

    public void UpdateDiamondText(Text _text)
    {
        _text.text = "" + diamonds;
    }
}
