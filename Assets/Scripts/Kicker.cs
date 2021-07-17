using DG.Tweening;
using UnityEngine;

public class Kicker : MonoBehaviour
{
    [SerializeField] Health health;

    public void Kick()
    {
        health.health = Mathf.Clamp(health.health - 10, 0, 100);
        health.UpdateHealth();
    }
}
