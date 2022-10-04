
using UnityEngine;

 class SquireContener : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] Vector3 center;

    
    void Update()
    {
        Vector3 p = transform.position;

        float distance = Vector3.Distance(center, transform.position);

        if (distance > radius)
        {
            Vector3 nextPos = (p - center).normalized * radius;
            transform.position = nextPos;
                
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(center, radius);
    }

}
