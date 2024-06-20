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

    // ���� �޴��� ǥ���մϴ�.
    public void ShowMainMenu()
    {
        HideAllUI();
        mainMenuUI.SetActive(true);
    }

    // �Ͻ� ���� �޴��� ǥ���մϴ�.
    public void ShowPauseMenu()
    {
        HideAllUI();
        pauseMenuUI.SetActive(true);
    }

    // ���� ���� ȭ���� ǥ���մϴ�.
    public void ShowGameOverScreen()
    {
        HideAllUI();
        gameOverUI.SetActive(true);
    }

    // ��� UI �г��� ��Ȱ��ȭ�մϴ�.
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
