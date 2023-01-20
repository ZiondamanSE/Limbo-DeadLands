using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneLoader2 : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar;

    
    public void LoadScene(int levelIndex)
    {
        StartCoroutine(LoadSceneAsynchronously(levelIndex));
    }


    IEnumerator LoadSceneAsynchronously(int levelIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(levelIndex);
        loadingScreen.SetActive(true);
        while(!operation.isDone)
        {
            loadingBar.value = operation.progress;
            yield return null;
        }
    }
}
