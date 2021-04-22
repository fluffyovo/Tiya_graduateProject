using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestyoyOnLoad : MonoBehaviour
{
    private void Awake()
    {
        //if (SceneManager.LoadScene("Level2"))
        
        DontDestroyOnLoad(gameObject);

        
    }
    
}
