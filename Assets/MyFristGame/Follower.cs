using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;
    [SerializeField] AnimationCurve speedOverDistance;
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
        float distance = Vector3.Distance(transform.position, target.position);
        float speed = speedOverDistance.Evaluate(distance); // Változó sebesség a közeledés függvényében a grafikonon
        float maxStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, maxStep);

        if (targetPoint != selfPoint)
        {

            transform.rotation = Quaternion.LookRotation(targetPoint - selfPoint);
        }

    }

}
