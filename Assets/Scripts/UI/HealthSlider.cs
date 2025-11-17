using UnityEngine;
using UnityEngine.UI;
public class HealthSlider : MonoBehaviour
{
    [SerializeField] private Slider HealthBar;

    public void UpdateHealth(int CurrentValue, int MaxValue)
    {
        HealthBar.value = CurrentValue / MaxValue;
    }
}
