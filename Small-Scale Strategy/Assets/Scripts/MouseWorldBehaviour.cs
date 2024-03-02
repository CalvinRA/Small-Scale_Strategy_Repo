using System;
using UnityEngine;

public class MouseWorldBehaviour : MonoBehaviour
{
    private static MouseWorldBehaviour instance;
    [SerializeField] private LayerMask mousePlaneLyerMask;

    private void Awake()
    {
        instance = this;
    }
    
    public static Vector3 GetPoaition()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Physics.Raycast(ray, out RaycastHit raycastHit, float.MaxValue, instance.mousePlaneLyerMask);
        return raycastHit.point;
        
    }
}
