using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Escolha : MonoBehaviour
{
   public void ProxCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }
     
}
