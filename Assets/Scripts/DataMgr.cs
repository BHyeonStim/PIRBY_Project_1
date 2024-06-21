using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataMgr : MonoBehaviour
{
    public UserData userData;
    public GameData gmaeData;

    private string userDataPath;

    void Awake()
    {

        // 데이터 로드
        LoadUserData();
        LoadGameData();
    }

    public void SaveUserData()
    {

    }
    public void SaveGameData()
    {

    }

    public void LoadUserData()
    {

    }
        

    public void LoadGameData()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
