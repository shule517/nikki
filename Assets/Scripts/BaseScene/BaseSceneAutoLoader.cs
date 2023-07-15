using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class BaseSceneAutoLoader
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void LoadBaseScene()
    {
        const string baseSceneName = "BaseScene";

        // 一度だけロードする
        if (!SceneManager.GetSceneByName(baseSceneName).IsValid())
        {
            SceneManager.LoadScene(baseSceneName, LoadSceneMode.Additive);
        }

        Thread.Sleep(1000);
    }
}
