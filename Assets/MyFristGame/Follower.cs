using UnityEngine;

class Follower : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed = 2;
    [SerializeField] AnimationCurve speedOverDistance;

    [SerializeField] new Rigidbody rigidbody;

    void OnValidate()
    {
        if (rigidbody == null)
            rigidbody = GetComponent<Rigidbody>();
    }

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
        /*
          float maxStep = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(selfPoint, targetPoint, maxStep);
        */

        Vector3 _direction = targetPoint - selfPoint;
        _direction.Normalize();

        rigidbody.velocity = _direction * speed;

        if (targetPoint != selfPoint)
        {
            Vector3 v = targetPoint - selfPoint;
            v.y = 0;
            transform.rotation = Quaternion.LookRotation(v);
        }

    }

}
