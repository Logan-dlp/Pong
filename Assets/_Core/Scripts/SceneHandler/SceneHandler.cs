using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pong.SceneHandler 
{
    public class SceneHandler : MonoBehaviour
    {
        public static SceneHandler instance;

        void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(instance.gameObject);
            }
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        public void LoadMenu()
        {
            SceneManager.LoadScene("MenuScene");
        }

        public void LoadGame()
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
