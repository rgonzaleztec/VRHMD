using System.Collections;
using UnityEngine;

public class spawMagicBalls : MonoBehaviour
{
    [Header("Prefabs de Magic Balls")]
    public GameObject PreFabMagicBall1;
    public GameObject PreFabMagicBall2;
    public GameObject PreFabMagicBall3;

    [Header("Punto de Lanzamiento Magic Balls")]
    public Transform puntoMagicBall1;
    public Transform puntoMagicBall2;
    public Transform puntoMagicBall3;

    [Header("Contador de Magic Balls")]
    public int MagicBall1;
    public int MagicBall2;
    public int MagicBall3;
    private int MaxMagicBall1;
    private int MaxMagicBall2;
    private int MaxMagicBall3;

    // Propiedades internas de control
    private bool magicball1create=false;
    private bool magicball2create = false;
    private bool magicball3create = false;

    private int contadormagicball1=0;
    private int contadormagicball2 = 0;
    private int contadormagicball3 = 0;


    // Update is called once per frame
    void Update()
    {
        contadormagicball1 = LanzarMagicBall1(contadormagicball1);
        contadormagicball2 = LanzarMagicBall2(contadormagicball2);
        contadormagicball3 = LanzarMagicBall3(contadormagicball3);
    }

    int LanzarMagicBall1(int localcont)
    {
        
        if ((MaxMagicBall1 >= localcont) && (!magicball1create))
            {
                StartCoroutine(lanzarMagicBall1());
                return localcont++;
            }
        return localcont;
    }

    int LanzarMagicBall2(int localcont)
    {
        
        if ((MaxMagicBall2 >= localcont) && (!magicball2create))
        {
            StartCoroutine(lanzarMagicBall2());
            return localcont++;
        }
        return localcont;
    }

    int LanzarMagicBall3(int localcont)
    {

        if ((MaxMagicBall3 >= localcont) && (!magicball3create))
        {
            StartCoroutine(lanzarMagicBall3());
            return localcont++;
        }
        return localcont;
    }

    IEnumerator lanzarMagicBall1()
    { 
        magicball1create = true;
        Instantiate(PreFabMagicBall1, puntoMagicBall1);
        yield return new WaitForSeconds(2);
        magicball1create = false;
        yield return null;
    }

    IEnumerator lanzarMagicBall2()
    {
        magicball2create = true;
        yield return new WaitForSeconds(7);
        Instantiate(PreFabMagicBall2, puntoMagicBall2);
        
        magicball2create = false;
    }

    IEnumerator lanzarMagicBall3()
    {
        magicball3create = true;
        yield return new WaitForSeconds(11);
        Instantiate(PreFabMagicBall3, puntoMagicBall3);
        
        magicball3create = false;
    }
}
