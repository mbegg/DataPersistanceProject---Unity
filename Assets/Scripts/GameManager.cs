using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int bestScore = 0;
    public string playerName;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    [System.Serializable]

    class SaveData
    {
        public string name;
        public int score;
    }

    public void Save()
    {


    }

    public void Load()
    {
        
    }
}
