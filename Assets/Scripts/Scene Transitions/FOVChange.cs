using UnityEngine;
using System.Collections;

public class FOVChange : MonoBehaviour
{
    public Camera Camera;
    public float FOVChnage = 90f;
    public float transitionSpeed = 5f;

    private float originalFOV;

    private void Start()
    {
        originalFOV = Camera.fieldOfView;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine(ChangeFOV(FOVChnage));
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            StartCoroutine(ChangeFOV(originalFOV));
    }

    IEnumerator ChangeFOV(float target)
    {
        while (Camera.fieldOfView != target)
        {
            Camera.fieldOfView = Mathf.Lerp(
                Camera.fieldOfView,
                target,
                Time.deltaTime * transitionSpeed
            );

            yield return null;
        }
    }
}
