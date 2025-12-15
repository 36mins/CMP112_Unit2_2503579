using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterTVInsideTV : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(5);
    }
}
