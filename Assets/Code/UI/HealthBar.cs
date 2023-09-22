using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Slider healthSlider;
    [SerializeField] private HealthData data;

    private void Start()
    {
        healthSlider.maxValue = data.MaxHealth;
        data.OnChange.AddListener(OnHealthChanged);
    }

    public void OnHealthChanged()
    {
        healthSlider.value = data.Current;
    }
}
