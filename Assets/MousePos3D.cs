using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePos3D : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;

    private void Update()
    {
        Ray rayb = mainCamera.ScreenPointToRay(Input.mousePosition);
         if (Physics.Raycast(rayb, out RaycastHit raycastHit))
         {
             transform.position = raycastHit.point;
         }
    }
}
