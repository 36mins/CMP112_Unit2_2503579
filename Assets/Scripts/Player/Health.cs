using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class Health : MonoBehaviour
{
    public int MaxHealth;
    public int CurrentHealth;
    bool Apartment;
    public float PlayerHeight;
    public LayerMask ApartmentFloor;

    [SerializeField] HealthSlider healthSlider;

    private void Awake()
    {
        healthSlider = GetComponentInChildren<HealthSlider>();
    }

    private void Start()
    {
        healthSlider.UpdateHealth(CurrentHealth, MaxHealth);
    }
    private void Update()
    {
        Healing();
    }

    public void Damage(int damage)
    {
        CurrentHealth -= damage;
        healthSlider.UpdateHealth(CurrentHealth, MaxHealth);
        if(CurrentHealth <= 0)
        {
            //Go to death screen
        }
    }
    public void Healing()
    {
        Apartment = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.90f + 0.2f, ApartmentFloor);
        if (Apartment)
        {
            CurrentHealth += 1;
            CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        }
        healthSlider.UpdateHealth(CurrentHealth, MaxHealth);
    }
   
}
