using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("thaGame");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
