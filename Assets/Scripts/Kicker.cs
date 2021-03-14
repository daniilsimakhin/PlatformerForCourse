using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kicker : MonoBehaviour
{
    [SerializeField] private Health _healthController;

    public void Kick()
    {
        _healthController.SetHealth(_healthController.GetHealth() - Random.Range(0, 15f));
    }
}
