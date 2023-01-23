using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuPausa : MonoBehaviour
{
    [SerializeField] private GameObject menudepausa;

    [SerializeField] private GameObject cajadehabilidad;

    void Start()
    {
        Time.timeScale = 1f;
    }
    public void Pausa()
    {
        Time.timeScale = 0f;
        menudepausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        menudepausa.SetActive(false);
    }

    public void Habilidad()
    {
        cajadehabilidad.SetActive(true);
    }

    public void Hogar()
    {
        SceneManager.LoadScene("Assets/Scenes/Pantalla Inicial.unity");
    }
  
}
