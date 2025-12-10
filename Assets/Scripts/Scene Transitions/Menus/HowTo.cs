using UnityEngine;

public class HowTo : MonoBehaviour
{
    public GameObject howto;

    void Start()
    {
        howto.SetActive(false);
    }

    public void OnButton()
    {
        howto.SetActive(true);

    }



}
