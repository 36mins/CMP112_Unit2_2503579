using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(6);
    }
}
