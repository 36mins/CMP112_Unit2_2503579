using UnityEngine;
using UnityEngine.SceneManagement;

public class goto1 : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(7); //go to the final scene of the game
    }
}
