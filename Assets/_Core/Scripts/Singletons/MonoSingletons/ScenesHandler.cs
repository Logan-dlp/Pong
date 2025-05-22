using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pong.Singletons.MonoSingletons
{
    public class ScenesHandler : MonoSingleton<ScenesHandler>
    {
        public void ChangeScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName);
        }

        public void QuitGame()
        {
            Application.Quit();
        }
    }
}