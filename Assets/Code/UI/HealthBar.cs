using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Slider healthSlider;
    [SerializeField] private Health playerHealth;

    private void Start()
    {
        healthSlider.maxValue = playerHealth.MaxHealth;
    }

    public void OnHealthChanged()
    {
        healthSlider.value = playerHealth.Current;
    }
}
