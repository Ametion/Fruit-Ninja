using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneComponent : MonoBehaviour
{
    public void LoadScene(int sceneId) => SceneManager.LoadScene(sceneId);

    public void ReloadScene() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}