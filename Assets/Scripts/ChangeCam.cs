using UnityEngine;

public class ChangeCam : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    public Camera cam3;

    void Start()
    {
        cam1 = cam1.GetComponent<Camera>();
        cam2= cam2.GetComponent<Camera>();
        cam3 = cam3.GetComponent<Camera>();
        Invoke("Cam2", 3);
        Invoke("Cam3", 5);
    }

    private void Cam1()
    {
        cam2.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam1.gameObject.SetActive(true);
    }

    private void Cam2()
    {
        cam1.gameObject.SetActive(false);
        cam3.gameObject.SetActive(false);
        cam2.gameObject.SetActive(true);
    }

    private void Cam3()
    {
        cam2.gameObject.SetActive(false);
        cam1.gameObject.SetActive(false);
        cam3.gameObject.SetActive(true);
    }
}
