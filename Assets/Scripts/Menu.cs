using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Fase1()
    {
        SceneManager.LoadScene("Fase1");
    }

    public void MenuPrincipal()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void Vitoria()
    {
        SceneManager.LoadScene("Vitoria");
    }

    public void Derrota()
    {
        SceneManager.LoadScene("Derrota");
    }


}
