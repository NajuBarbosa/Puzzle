using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ControlerQB : MonoBehaviour
{  
    public GameObject pc1, pc2, pc3, pc4, pc5;
    public GameObject pc6, pc7, pc8, pc9;

    public GameObject pc1_fundo, pc2_fundo, pc3_fundo, pc4_fundo, pc5_fundo;
    public GameObject pc6_fundo, pc7_fundo, pc8_fundo, pc9_fundo;

    private Vector3 PosInit_pc1, PosInit_pc2, PosInit_pc3, PosInit_pc4, PosInit_pc5, PosInit_pc6;
    private Vector3 PosInit_pc7, PosInit_pc8, PosInit_pc9;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;

    bool Pc1Bool, Pc2Bool, Pc3Bool, Pc4Bool, Pc5Bool, Pc6Bool, Pc7Bool, Pc8Bool, Pc9Bool = false;

    public string ProximaCena;
    public string Vitoria;

    // Start is called before the first frame update
    void Start()
    {
        PosInit_pc1 = pc1.transform.position;
        PosInit_pc2 = pc2.transform.position;
        PosInit_pc3 = pc3.transform.position;
        PosInit_pc4 = pc4.transform.position;
        PosInit_pc5 = pc5.transform.position;
        PosInit_pc6 = pc6.transform.position;
        PosInit_pc7 = pc7.transform.position;
        PosInit_pc8 = pc8.transform.position;
        PosInit_pc9 = pc9.transform.position;
    }

    //pc1
    public void DropPc1()
    {
        float distance = Vector3.Distance(pc1.transform.position, pc1_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc1.transform.position = pc1_fundo.transform.position;
            pc1.transform.localScale = pc1_fundo.transform.localScale;
            Pc1Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc1.transform.position = PosInit_pc1;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragPc1()
    {
        pc1.transform.position = Input.mousePosition;
    }

    //pc2
    public void DropPc2()
    {
        float distance = Vector3.Distance(pc2.transform.position, pc2_fundo.transform.position);

        if (distance < 10)
        {
            pc2.transform.position = pc2_fundo.transform.position;
            pc2.transform.localScale = pc2_fundo.transform.localScale;
            Pc2Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc2.transform.position = PosInit_pc2;
            source.clip = incorrect;
            source.Play();
        }
    }
 
    public void DragPc2()
    {
        pc2.transform.position = Input.mousePosition;
    }
    //Pc3
    public void DropPc3()
    {
        float distance = Vector3.Distance(pc3.transform.position, pc3_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc3.transform.position = pc3_fundo.transform.position;
            pc3.transform.localScale = pc3_fundo.transform.localScale;
            Pc3Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc3.transform.position = PosInit_pc3;
            source.clip = incorrect;
            source.Play();
        }
    }
  
    public void DragPc3()
    {
        pc3.transform.position = Input.mousePosition;
    }
    //Pc4
    public void DropPc4()
    {
        float distance = Vector3.Distance(pc4.transform.position, pc4_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc4.transform.position = pc4_fundo.transform.position;
            pc4.transform.localScale = pc4_fundo.transform.localScale;
            Pc4Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc4.transform.position = PosInit_pc4;
            source.clip = incorrect;
            source.Play();
        }
    }
    public void DragPc4()
    {
        pc4.transform.position = Input.mousePosition;
    }
    //Pc5
    public void DropPc5()
    {
        float distance = Vector3.Distance(pc5.transform.position, pc5_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc5.transform.position = pc5_fundo.transform.position;
            pc5.transform.localScale = pc5_fundo.transform.localScale;
            Pc5Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc5.transform.position = PosInit_pc5;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragPc5()
    {
        pc5.transform.position = Input.mousePosition;
    }
    //Pc6
    public void DropPc6()
    {
        float distance = Vector3.Distance(pc6.transform.position, pc6_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc6.transform.position = pc6_fundo.transform.position;
            pc6.transform.localScale = pc6_fundo.transform.localScale;
            Pc6Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc6.transform.position = PosInit_pc6;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragPc6()
    {
        pc6.transform.position = Input.mousePosition;
    }
    //Pc7
    public void DropPc7()
    {
        float distance = Vector3.Distance(pc7.transform.position, pc7_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc7.transform.position = pc7_fundo.transform.position;
            pc7.transform.localScale = pc7_fundo.transform.localScale;
            Pc7Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc7.transform.position = PosInit_pc7;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragPc7()
    {
        pc7.transform.position = Input.mousePosition;
    }
    //Pc8
    public void DropPc8()
    {
        float distance = Vector3.Distance(pc8.transform.position, pc8_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc8.transform.position = pc8_fundo.transform.position;
            pc8.transform.localScale = pc8_fundo.transform.localScale;
            Pc8Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc8.transform.position = PosInit_pc8;
            source.clip = incorrect;
            source.Play();
        }
    }

    public void DragPc8()
    {
        pc8.transform.position = Input.mousePosition;
    }
    //Pc9
    public void DropPc9()
    {
        float distance = Vector3.Distance(pc9.transform.position, pc9_fundo.transform.position);
        print(distance);
        if (distance < 10)
        {
            pc9.transform.position = pc9_fundo.transform.position;
            pc9.transform.localScale = pc9_fundo.transform.localScale;
            Pc9Bool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            pc9.transform.position = PosInit_pc9;
            source.clip = incorrect;
            source.Play();
        }

    }
    public void DragPc9()
    {
        pc9.transform.position = Input.mousePosition;
    }
    void Update()
    {
        if (Pc1Bool && Pc2Bool && Pc3Bool && Pc4Bool && Pc5Bool && Pc6Bool && Pc7Bool && Pc8Bool && Pc9Bool || Timer.time <= 0)
        {

            StartCoroutine(LoadNextScene());
        }
        if (Pc1Bool && Pc2Bool && Pc3Bool && Pc4Bool && Pc5Bool && Pc6Bool && Pc7Bool && Pc8Bool && Pc9Bool == true)
        {
            SceneManager.LoadScene(Vitoria);
        }
    }

    IEnumerator LoadNextScene()
    {

        yield return new WaitForSeconds(4f);
        SceneManager.LoadScene(ProximaCena);

    }

    public void Exit()
    {
        Application.Quit();
    }

}
