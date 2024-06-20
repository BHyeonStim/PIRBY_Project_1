using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMgr : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameObject pauseMenuUI;
    public GameObject gameOverUI;

    void Start()
    {

    }

    // 메인 메뉴를 표시합니다.
    public void ShowMainMenu()
    {
        HideAllUI();
        mainMenuUI.SetActive(true);
    }

    // 일시 정지 메뉴를 표시합니다.
    public void ShowPauseMenu()
    {
        HideAllUI();
        pauseMenuUI.SetActive(true);
    }

    // 게임 오버 화면을 표시합니다.
    public void ShowGameOverScreen()
    {
        HideAllUI();
        gameOverUI.SetActive(true);
    }

    // 모든 UI 패널을 비활성화합니다.
    private void HideAllUI()
    {
        mainMenuUI.SetActive(false);
        pauseMenuUI.SetActive(false);
        gameOverUI.SetActive(false);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
