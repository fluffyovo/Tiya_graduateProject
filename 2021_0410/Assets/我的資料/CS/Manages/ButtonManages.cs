using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManages : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Enent1");
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene("How");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");

    }

    public void Skip()
    {
        SceneManager.LoadScene("Level1");

    }

    public void Pause()
    {
        EventManager._instance.transformGameState();
    }
}
