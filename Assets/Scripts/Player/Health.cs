using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using TMPro;

public class Health : MonoBehaviour
{
    [Header("Health")]
    public int MaxHealth;
    public int CurrentHealth;

    [Header("Regen")]
    public float HealthRegen = 5f;
    bool Apartment;
    public float PlayerHeight;
    public LayerMask ApartmentFloor;

    [Header("UI")]
    public TextMeshProUGUI HealthText;
    void Awake()
    {
        if (FindObjectsOfType<Health>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        CurrentHealth = MaxHealth;
        UpdateHealthUI();
    }

    private void Update()
    {
        Healing();
        UpdateHealthUI();
    }

    public void Damage(int damage)
    {
        CurrentHealth -= damage;
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);

        if (CurrentHealth <= 0)
        {
            //Go to death screen
        }
        UpdateHealthUI();
    }
    public void Healing()
    {
        Apartment = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.90f + 0.2f, ApartmentFloor);
        if (Apartment && CurrentHealth < MaxHealth)
        {
            CurrentHealth += Mathf.RoundToInt(HealthRegen * Time.deltaTime);
            CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        }
        
    }
    void UpdateHealthUI()
    {
        HealthText.text = System.Convert.ToString("Health: " + CurrentHealth);
        
    }
}
