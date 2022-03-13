using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
	private GameObject HomeCanvas;
    [SerializeField]
	private GameObject AtividadeCanvas;
    public void Fecha_Projeto()
    {
        Application.Quit();
    }
    public void Fecha_MenuPrincipal()
    {
        HomeCanvas.SetActive(false);
        AtividadeCanvas.SetActive(true);
    }
    public void Abre_MenuPrincipal()
    {
        AtividadeCanvas.SetActive(false);
        HomeCanvas.SetActive(true);
    }
}
