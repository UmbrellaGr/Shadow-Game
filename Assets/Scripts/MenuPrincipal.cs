using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{


    // Cargar o dirigir a la ventana del primer nivel
    public void Iniciar() // Funcion publica Iniciar
    {
        SceneManager.LoadScene("Assets/Scenes/Nivel1.unity"); // Cargar la escena inical del juego
    }


    // Cargar o dirigir a la ventana de las Habilidades
    public void Habilidades() // Funcion publica Habilidades
    {
        SceneManager.LoadScene(""); // Cargar escena Habilidades
    }


    // Cargar o dirigir a la ventana de los niveles
    public void Niveles() // Funcion publica Niveles
    {

    }
}
