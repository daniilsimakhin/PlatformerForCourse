using DG.Tweening;
using UnityEngine;

public class Kicker : MonoBehaviour
{
    [SerializeField] private Character _character;

    public void Kick()
    {
        _character.ApplyDamage(10);
    }
}
