using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Labirint
{
    public class GameController : MonoBehaviour
    {
        private Reference _reference = new Reference();
        private Text text;

        private void Awake()
        {
            text = _reference.EndLevellabel.gameObject.GetComponentInChildren<Text>();
            _reference.RestartButton.onClick.AddListener(RestartGame);
            _reference.RestartButton.gameObject.SetActive(false);
            _reference.EndLevellabel.gameObject.SetActive(false);
        }
        public void Win()
        {
            text.text = "Уровень пройден";
            _reference.EndLevellabel.gameObject.SetActive(true);
        }

        public void GameOver()
        {
            text.text = "Вы проиграли";
            _reference.RestartButton.gameObject.SetActive(true);
            _reference.EndLevellabel.gameObject.SetActive(true);
        }
        private void RestartGame()
        {
            SceneManager.LoadScene(0);
            Time.timeScale = 1.0f;
        }
    }
}
