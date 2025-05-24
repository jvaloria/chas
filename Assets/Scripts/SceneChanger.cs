using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    /// <summary>
    /// Loads a scene based on the specified scene name.
    /// </summary>
    /// <param name="sceneName">The name of the scene to be loaded.</param>
    public void LoadSceneByName(string sceneName)
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not specified!");
        }
    }

    /// <summary>
    /// Loads a scene based on the specified build index.
    /// </summary>
    /// <param name="sceneBuildIndex">The build index of the scene to be loaded.</param>
    public void LoadSceneByIndex(int sceneBuildIndex)
    {
        SceneManager.LoadScene(sceneBuildIndex);
    }

    public void QuitGame()
    {
        // If the game is running in the editor, stop playing
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
