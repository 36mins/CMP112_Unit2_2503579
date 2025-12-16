using UnityEngine;
using UnityEngine.SceneManagement;

public class goto1 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(7);
    }
}
