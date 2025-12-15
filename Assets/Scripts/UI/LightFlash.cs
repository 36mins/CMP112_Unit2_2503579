using UnityEngine;

[RequireComponent(typeof(Light))]
public class FlashLight : MonoBehaviour
{
    [Header("Timing")]
    public float lightCD = 3f;          
    public float flashDuration = 1f;    
    public float offset = 0f;

    [Header("Light")]
    public float maxBrightness = 4f;
    private float lightTimer;
    private float flashTimer;
    private Light flash;

    void Start()
    {
        flash = GetComponent<Light>();
        flash.enabled = false;
        flash.intensity = 0f;

        lightTimer = lightCD + offset;
        flashTimer = flashDuration;
    }

    void Update()
    {
       
        if (lightTimer > 0f)
        {
            lightTimer -= Time.deltaTime;
            flash.enabled = true;
            WarningLight();
        }
       
        else
        {
            flash.enabled = true;
            Flash();

            flashTimer -= Time.deltaTime;
            if (flashTimer <= 0f)
                ResetTimer();
        }


    }

    void WarningLight()
    {
        float t = 1f - (lightTimer / lightCD);
        flash.intensity = Mathf.Lerp(0f, maxBrightness * 0.3f, t);
    }

    void Flash()
    {
        flash.intensity = maxBrightness;
    }

    void ResetTimer()
    {
        lightTimer = lightCD;
        flashTimer = flashDuration;
        flash.intensity = 0f;
        flash.enabled = false;
    }
}
