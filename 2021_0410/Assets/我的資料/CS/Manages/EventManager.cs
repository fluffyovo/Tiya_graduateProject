using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameState
{
    //枚舉遊戲狀態
    Running,
    Pause
}

public class EventManager : MonoBehaviour
{

    public GameState gamestate = GameState.Running;

    public static EventManager _instance;

    void Awake()
    {
        _instance = this;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("Level1");
    }

    public void transformGameState()
    {
        if (gamestate == GameState.Running)
        {
            GamePause();
        }
        else if (gamestate == GameState.Pause)
        {
            ContinueGame();
        }
    }

    public void GamePause()
    {
        Time.timeScale = 0;//Time.deltaTime=0 0代表暫停
        gamestate = GameState.Pause;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;//Time.deltaTime=1 1代表使遊戲運行
        gamestate = GameState.Running;
    }
}
