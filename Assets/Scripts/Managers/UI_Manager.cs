using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
	private GameObject HomeCanvas;
    [SerializeField]
	private GameObject AtividadeCanvas;
    [SerializeField]
	private GameObject PlayerInputManager;
    [SerializeField]
	private GameObject PyramixManager;
    void Awake(){
        PlayerInputManager.SetActive(false);
        PyramixManager.SetActive(false);
        HomeCanvas.SetActive(true);
        AtividadeCanvas.SetActive(false);
    }
    public void Fecha_Projeto()
    {
        Application.Quit();
    }
    public void Fecha_MenuPrincipal()
    {
        HomeCanvas.SetActive(false);
        AtividadeCanvas.SetActive(true);
        PlayerInputManager.SetActive(true);
        PyramixManager.SetActive(true);
    }
    public void Abre_MenuPrincipal()
    {
        SceneManager.LoadScene("Trabalho");
    }
}
