using UnityEngine;

public class UnitBehaviour : MonoBehaviour
{

    [SerializeField] private Animator UnitAnimator;
    private Vector3 targetPosition;

    private void Update()
    {   
        
        float stoppingDistance = .1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            
            UnitAnimator.SetBool("IsWalking", true);
        }
        else
        {
            UnitAnimator.SetBool("IsWalking", false);
        }
        
        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorldBehaviour.GetPosition());
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}
