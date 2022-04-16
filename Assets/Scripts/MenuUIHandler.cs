using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    public InputField Name;
    public Text HighScore;

    public void Start()
    {
        DataManager.Instance.Load();
        int points = DataManager.Instance.Score;
        string player = DataManager.Instance.Name;
        HighScore.text = $"High score : {points} : {player}";
    }
    public void StartGame()
    {
        if (Name.text.Length > 0)
        {
            SceneManager.LoadScene(1);
        }
        else
            return;
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }

    public void InputName()
    {
        DataManager.Instance.Name = Name.text;
    }
}
