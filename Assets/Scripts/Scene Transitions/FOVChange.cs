using UnityEngine;
using System.Collections;

public class FOVChange : MonoBehaviour
{
    public Camera Camera;
    public float FOVChnage = 180f;
    public float transitionSpeed = 20f;

    private float originalFOV;

    private void Start()
    {
        originalFOV = Camera.fieldOfView;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine(ChangeFOV(FOVChnage));   //Once enetered starts changing the players FOV to 180
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine(ChangeFOV(originalFOV)); //starts moving the FOV back to noraml
    }

    IEnumerator ChangeFOV(float target)
    {
        while (Camera.fieldOfView != target)
        {
            Camera.fieldOfView = Mathf.Lerp(Camera.fieldOfView, target, Time.deltaTime * transitionSpeed); //Slowly moves the FOV to the target FOV
            yield return null;
        }
    }
}
