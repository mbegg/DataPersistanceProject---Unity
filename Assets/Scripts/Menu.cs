using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class Menu : MonoBehaviour
{
    [SerializeField] TMP_InputField nameText;
    [SerializeField] TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        nameText.interactable = true;
        if (GameManager.Instance.highSoreName != null)
        {
            text.text = $"Best Score: {GameManager.Instance.highSoreName} : {GameManager.Instance.bestScore}";
        }
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
