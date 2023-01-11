using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void CargarNuevaEscena(int numEscena)
    {
        SceneManager.LoadScene(numEscena);
    }
}
