using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;

     void Update()
    {
        Vector3 targetPoint = target.position;
        Vector3 selfPoint = transform.position;
        /*

        Vector3 velocity = targetPoint - selfPoint;
        velocity.Normalize();
        velocity *= speed;
        velocity *= Time.deltaTime;
        float stepDistance = velocity.magnitude;
        float targetDistance = Vector3.Distance(targetPoint, selfPoint);
        if (targetDistance < stepDistance)
        {
            velocity.Normalize();
            velocity *= targetDistance;
        
        }

        transform.position += velocity * Time.deltaTime;
        */
        float maxStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, maxStep);

        transform.rotation = Quaternion.LookRotation(targetPoint -selfPoint);

    }

}
