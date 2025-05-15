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
                Destroy(gameObject);
            }
            instance = this;
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
