using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Healer : MonoBehaviour
{
    [SerializeField] private Health _healthController;

    public void Heal()
    {
        _healthController.SetHealth(_healthController.GetHealth() + Random.Range(0, 15f));
    }
}
