using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Text _healthDisplay;

    public void SetHealthDisplay(float hp)
    {
        _healthDisplay.text = $"Health: {hp.ToString("F0")}";
    }
}
