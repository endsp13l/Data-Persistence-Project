using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public InputField Name;
    public Text HighScore;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
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
        Debug.Log($"input{ DataManager.Instance.Name}");
    }
}
