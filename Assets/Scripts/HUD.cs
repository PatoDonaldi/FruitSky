using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD instance;
    public Text pontosText;
    public Text vidasText;

    private int pontos = 0;
    private int vidas = 3;

    void Awake()
    {
        instance = this;
        UpdateHUD();
    }

    public void AddPoints(int value)
    {
        pontos += value;
        UpdateHUD();
    }

    public void LoseLife()
    {
        vidas--;
        UpdateHUD();
        if (vidas <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("MainScene");
        }
    }

    void UpdateHUD()
    {
        pontosText.text = "Pontos: " + pontos;
        vidasText.text = "Vidas: " + vidas;
    }
}
