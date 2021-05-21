using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    public Player _Player;

    void Start()
    {
        
    }

    void Update()
    {
        if (_Player == null)
        {
            _Player = GameObject.FindWithTag("Player").GetComponent<Player>();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(_Player.gameObject);
            SceneManager.LoadScene("Level2"); 
        }

    }


    
}
