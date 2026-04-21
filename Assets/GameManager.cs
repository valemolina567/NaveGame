using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public GameObject restartButton;

    public void Win()
    {
        resultText.gameObject.SetActive(true);
        restartButton.SetActive(true);

        resultText.text = "GANASTE";
    }

    public void Lose()
    {
        resultText.gameObject.SetActive(true);
        restartButton.SetActive(true);

        resultText.text = "PERDISTE";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}