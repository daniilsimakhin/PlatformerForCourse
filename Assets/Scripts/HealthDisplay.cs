using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    [SerializeField] private Slider _healthSlider;
    [SerializeField] private Text _healthDisplay;
    [SerializeField] private Character _character;

    private void OnEnable()
    {
        _character.HealthChanged += OnHealthChanged;
    }

    private void OnHealthChanged(int health)
    {
        _healthDisplay.text = $"Health: {health.ToString()}";
        _healthSlider.value = health;
    }

    private void OnDisable()
    {
        _character.HealthChanged -= OnHealthChanged;
    }
}
