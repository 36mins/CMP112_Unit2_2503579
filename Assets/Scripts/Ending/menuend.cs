using UnityEngine;
using UnityEngine.SceneManagement;

public class menuend : MonoBehaviour
{
   public void OnButton()
   {
        SceneManager.LoadScene(0); //once pressed the button will take the player to the main menu
   }
}
