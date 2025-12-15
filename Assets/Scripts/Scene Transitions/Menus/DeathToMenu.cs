using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathToMenu : MonoBehaviour
{
    public void OnButton()
    {
        SceneManager.LoadScene(0);
    }

}
