using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DisplayScore : MonoBehaviour, IPresenter<int>
{
    [SerializeField] private string _pattern = "Score: {0}";
    [SerializeField] private Text _display;

    public void Present(int value)
    {
        _display.text = string.Format(_pattern, value);
    }
}
