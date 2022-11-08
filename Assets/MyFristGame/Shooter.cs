
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

    int _count = 0;
    int _bulletIndex = 0;


     void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))

        {
            Shoot();

        }
    }

    
    void Shoot()
    {
        GameObject proto;
        if (pattern == _ShootingPattern.Random)

        {
            int _randomNum = Random.Range(0, _ps.Length);
            proto = _ps[_randomNum];
        }
        else if (pattern == _ShootingPattern.Sequence)
        {
            int _index = _count % _ps.Length;
            proto = _ps[_index];
        }
        else
        {
            int _safeindex = Mathf.Clamp(_bulletIndex, 0, _ps.Length - 1);
            proto = _ps[_safeindex];
        }
        GameObject _p = Instantiate(proto);

        _p.transform.position = transform.position;

        Rigidbody _rb = _p.GetComponent<Rigidbody>();

        Vector3 _direction = transform.forward;

        Vector3 _v = transform.TransformVector(Vector3.up);
        Vector3 _v2 = transform.InverseTransformVector(_v);


        _direction.Normalize();


        _rb.velocity = _direction * speed;

        _count++;
    }

}
