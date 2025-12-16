using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.Rendering.DebugUI;

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
    float Regen;


    [Header("UI")]
    public TextMeshProUGUI HealthText;
    void Awake()
    {
        if (FindObjectsOfType<Health>().Length > 1)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject); //makes sure the players Health value is carried across different scenes
    }

    void Start()
    {
        CurrentHealth = MaxHealth;
        UpdateHealthUI();
    }

    private void Update()
    {
        Healing();  //Checks if the player can be healed
        UpdateHealthUI();
    }

    public void Damage(int damage)
    {
        CurrentHealth -= damage;    //Redcuses health by the damage taken
        CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);   //Prevents Negative Health

        if (CurrentHealth <= 0)
        {
            SceneManager.LoadScene(4);  //Load death scene if the player dies
        }
        UpdateHealthUI();
    }
    public void Healing()
    {
        Apartment = Physics.Raycast(transform.position, Vector3.down, PlayerHeight * 0.90f + 0.2f, ApartmentFloor); //Checks if the player is in the aprtment
        Debug.Log("healing");
        if (Apartment && CurrentHealth < MaxHealth) //If they are then
        {
            Regen += HealthRegen * Time.deltaTime;  //How much HP regend per second
            if (Regen >= 1f)
            {
                int healAmount = Mathf.FloorToInt(Regen);   //Heals in whole numbers
                CurrentHealth += healAmount;    //adds the healed amount to the players current health
                Regen -= healAmount;    //Makes the Regen more precise
            }

            CurrentHealth = Mathf.Clamp(CurrentHealth, 0, MaxHealth);
        }
        
    }
    void UpdateHealthUI()
    {
        HealthText.text = System.Convert.ToString("Health: " + CurrentHealth); //Updates the UI for health
        
    }
}
