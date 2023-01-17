using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Disparar : MonoBehaviour
{
    public Transform posicionBala;
    public GameObject BalaPrefab;
    public float velocidadBala = 10;


   public void DispararUnaBala()
        {
        var balanueva = Instantiate(BalaPrefab);
        balanueva.transform.position = posicionBala.position;
        balanueva.GetComponent<Rigidbody>().velocity = posicionBala.forward * velocidadBala;
        Destroy(balanueva, 3);
        }

    private void Start()
    {
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        grabbable.activated.AddListener(BalaDisparada);
    }

    public void BalaDisparada(ActivateEventArgs arg)
    {
        DispararUnaBala();
    }

}
