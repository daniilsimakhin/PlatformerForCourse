using DG.Tweening;
using UnityEngine;

public class Healer : MonoBehaviour
{
    [SerializeField] Health health;

    public void Heal()
    {
        health.health = Mathf.Clamp(health.health + 10, 0, 100);
        health.UpdateHealth();
    }
}
