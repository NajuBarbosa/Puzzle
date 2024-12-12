using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public string ProximaCena;
  
    public void CenaSeguinte()
    {
        SceneManager.LoadScene(ProximaCena);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
