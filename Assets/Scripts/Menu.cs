using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class Menu : MonoBehaviour
{
    [SerializeField] TMP_InputField nameText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        GameManager.Instance.playerName = nameText.text.Length > 0 ? nameText.text : "Anonymous";

        SceneManager.LoadScene("main");
    }
    public void Exit()
    {
        GameManager.Instance.Save();
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();

#else
        Application.Quit();
#endif
    }
}
