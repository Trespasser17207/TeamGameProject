using UnityEngine;
using UnityEngine.InputSystem;

public class ProjectilePouch : MonoBehaviour
{
    Camera m_Camera;
    Vector3 cameraPos;
    public float maxRayDistance = 10.0f;
    public LayerMask pickLayer;

    private void Awake()
    {
        m_Camera = Camera.main;
        cameraPos = m_Camera.transform.position;
    }

    private void Update()
    {
        Mouse mouse = Mouse.current;
        if (mouse.leftButton.wasPressedThisFrame)
        {
            Vector2 screenPos = mouse.position.ReadValue();
            Ray picker = m_Camera.ScreenPointToRay(screenPos);
            
            RaycastHit hitInfo;
            if (Physics.Raycast(picker, out hitInfo, maxRayDistance, pickLayer))
            {
                //We hit something
                if(hitInfo.collider.CompareTag("Pouch"))
                    Debug.Log(hitInfo.collider.gameObject.name);
            }
        }
    }
}
