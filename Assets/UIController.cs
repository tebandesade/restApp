using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour
{
    public GameObject m_kitten;
    private TangoPointCloud m_pointCloud;
    public Controlador contr;
    public foodLogic fLo;
    void Start()
    {
        m_pointCloud = FindObjectOfType<TangoPointCloud>();
        m_kitten = fLo.darArActual();
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            Debug.Log("Entro a input touch");
            // Trigger place kitten function when single touch ended.
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Ended)
            {
                PlaceKitten(t.position);
            }
        }
/// poneBack();
    }

    public void poneBack()
    {
        Debug.Log("Entro a AR");
        if (Input.touchCount == 1)
        {
            // Trigger place kitten function when single touch ended.
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began )
            {
   
                Ray ray = Camera.main.ScreenPointToRay(t.position);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit)  )
                {
                   ///ntr.cambiarMenu();
                }
            }
        }
    }

    void PlaceKitten(Vector2 touchPosition)
    {
        // Find the plane.
        Camera cam = Camera.main;
        Debug.Log(cam);
        Vector3 planeCenter;
        Plane plane;

        if (!m_pointCloud.FindPlane(cam, touchPosition, out planeCenter, out plane))
        {
            Debug.Log("cannot find plane.");
            return;
        }

        // Place kitten on the surface, and make it always face the camera.
        if (Vector3.Angle(plane.normal, Vector3.up) < 30.0f)
        {
            Vector3 up = plane.normal;
            Vector3 right = Vector3.Cross(plane.normal, cam.transform.forward).normalized;
            Vector3 forward = Vector3.Cross(right, plane.normal).normalized;
            Instantiate(m_kitten, planeCenter, Quaternion.LookRotation(forward, up));
        }
        else
        {
            Debug.Log("surface is too steep for kitten to stand on.");
        }
    }
}
