using DG.Tweening;
using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] private Character _character;

    public void Heal()
    {
        _character.ApplyHeal(10);
    }
}
