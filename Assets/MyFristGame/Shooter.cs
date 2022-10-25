
using UnityEngine;

 class Shooter : MonoBehaviour
{
    enum _ShootingPattern
    {
        Random, Sequence, Keyboard
    }


    [SerializeField] GameObject[] _ps;
    [SerializeField] float speed;
    [SerializeField] _ShootingPattern pattern;
    int count = 0;
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))

          {
            GameObject proto;
            if (pattern == _ShootingPattern.Random)

            {
                int _randomNum = Random.Range(0, _ps.Length);
                 proto = _ps[_randomNum];
            }
            else
            {
                int _index = count % _ps.Length;
                proto = _ps [_index];
            }
            GameObject _p = Instantiate(proto);

            _p.transform.position = transform.position;

            Rigidbody _rb = _p.GetComponent<Rigidbody>();

            Vector3 _direction = transform.forward;

            Vector3 _v = transform.TransformVector(Vector3.up);
            Vector3 _v2 = transform.InverseTransformVector(_v);

           
            _direction.Normalize();


            _rb.velocity = _direction * speed;

            count++;


        }
    }


}
