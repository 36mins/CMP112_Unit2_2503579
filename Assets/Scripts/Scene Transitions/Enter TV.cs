using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterTV : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene(2);  //Loads the second scene
    }
}
