using UnityEngine;
using UnityEngine.Events;

public class UnitBehaviour : MonoBehaviour
{
    private Vector3 targetPosition;

    private void Update()
    {
        float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorldBehaviour.GetPoaition());
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}