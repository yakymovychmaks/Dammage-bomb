using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public Airplane airplane;

    private void Start()
    {
        SetMaxtHealth(airplane.hp);
    }

    private void Update()
    {
        SetHealth(airplane.hp);
    }

    public void SetMaxtHealth(int heals)
    {
        slider.maxValue = heals;
        slider.value = heals;
    }
    public void SetHealth(int heals)
    {
        slider.value = heals;
    }

}
