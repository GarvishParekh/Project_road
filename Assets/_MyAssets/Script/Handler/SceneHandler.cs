using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    private void OnEnable()
    {
        ActionHandler.ChangeScene += OnChangeScene;
    }

    private void OnDisable()
    {
        ActionHandler.ChangeScene -= OnChangeScene;
    }

    private void OnChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
