using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    public float GetHealth()
    {
        return _slider.value;
    }

    public void SetHealth(float value)
    {
        _slider.value = value;
    }
}
