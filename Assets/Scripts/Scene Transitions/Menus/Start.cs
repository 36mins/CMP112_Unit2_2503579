using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    public void OnButton()
    {
        SceneManager.LoadScene(1);  //Sends the player to the 1st scene
    }
}
