using UnityEngine;
using UnityEngine.UI;

public class PauseManager : MonoBehaviour
{
    public Button playButton;
    public Button pauseButton;

    void Start()
    {
        playButton.onClick.AddListener(ResumeGame);
        pauseButton.onClick.AddListener(PauseGame);

        playButton.gameObject.SetActive(false); // Start hidden
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseButton.gameObject.SetActive(false);
        playButton.gameObject.SetActive(true);
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        playButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }
}
