using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MenuButton : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvas;

    public void ButtonPlay()
    {
        _canvas.blocksRaycasts = false;
        _canvas.DOFade(0, 1);
    }
}
