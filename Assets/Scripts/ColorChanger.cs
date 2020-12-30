using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Image _background;

    private Color _startColor;

    public void Start()
    {
        _startColor = _background.color;
    }

    public void ChangeColor(float value)
    {
        if (value == 0)
        {
            _background.color = _startColor;
        }
        else
        {
            _background.color = new Color(1 - value, 1 - value, value);
        }
    }
}
