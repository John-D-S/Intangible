using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    /// <summary>
    /// change to the scene with the given scene build index
    /// </summary>
    public void ChangeToScene(int _sceneIndex)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_sceneIndex);
    }

    /// <summary>
    /// quit the game
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
