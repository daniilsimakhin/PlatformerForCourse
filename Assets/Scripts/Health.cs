using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Text healthLabel;
    public Slider healthSlider;

    public int health;

    public void UpdateHealth()
    {
        healthLabel.text = $"Health: {health.ToString("F0")}";
        healthSlider.value = health;
    }
}
