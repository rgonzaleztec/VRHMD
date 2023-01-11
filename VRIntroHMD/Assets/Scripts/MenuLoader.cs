using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuLoader : MonoBehaviour
{
    private AudioSource _miAudioAmbiente;
    [SerializeField] Slider _miSliderVolumen;


    private void Start()
    {
        _miAudioAmbiente = GetComponent<AudioSource>();
    }


    public void CambiarVolumen()
    {
        _miAudioAmbiente.volume = _miSliderVolumen.value;
    }


    public void CargarNuevaEscena(int numEscena)
    {
        SceneManager.LoadScene(numEscena);
    }


    public void SalirApp()
    {
        Application.Quit();
    }
}
