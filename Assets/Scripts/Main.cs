using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InitializeGame();

        LoadInitialScene();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void InitializeGame()
    {
       // GameManager.Instance.Initialize();
       // SoundManager.Instance.Initialize();
       // UIManager.Instance.Initialize();

        Debug.Log("Game Initialzied");
    }

    void LoadInitialScene()
    {
        SceneManager.LoadScene("MainScene");
    }    
}
