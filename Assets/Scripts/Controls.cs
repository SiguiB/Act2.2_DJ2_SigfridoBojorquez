using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controls : MonoBehaviour
{
   
    public void EscenaJuego() {
        SceneManager.LoadScene("Page1");
    }
    public void CargarPagina(string Pagina) {
        SceneManager.LoadScene(Pagina);
    }
    public void Salir() {
        Application.Quit();
    }
    public void LinkExt(string Link) {
        Application.OpenURL(Link);
    }
}
