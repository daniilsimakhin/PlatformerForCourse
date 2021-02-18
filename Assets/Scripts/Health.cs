using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Health : MonoBehaviour
{
    [SerializeField] private Slider _rectSlider;
    [SerializeField] private float _health;
    [SerializeField] private float _hp;
    
    public void Healing()
    {
        _health = Mathf.Clamp(_health + 0.1f, 0, 1);
        _rectSlider.DOValue(_health, 0.3f);
    }

    public void Kick()
    {
        _health = Mathf.Clamp(_health - 0.1f, 0, 1);
        _rectSlider.DOValue(_health, 0.3f);
    }
}
