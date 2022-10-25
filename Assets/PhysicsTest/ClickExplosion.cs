
using UnityEngine;

class ClickExplosion : MonoBehaviour

// ctrl+k+d = automatikus igaz�t�s
// ctrl+rr = mindent �tnevez egyszerre
// for ciklus alapkoncepci� ki�r�sa tab*2
// ctrl+space = met�dus aj�nlatok k�r�se
{
    [SerializeField] float _maxForce;
    [SerializeField] float _range;
    [SerializeField] float _upward;
    [SerializeField] LayerMask _raycastLayers;
    [SerializeField] ParticleSystem _partyclesystem;

    Vector3 _lastRayHit;
    Rigidbody[] _rigidbodies; // T�mb�s�t�s [] b�rmivel v�grehajthat�


    void Start()
    {
        _rigidbodies = FindObjectsOfType<Rigidbody>();

    }

    void Update()
    {
        // Kattint�sra
        if (Input.GetMouseButtonDown(0))
        {

            Camera _cam = Camera.main;

            Vector3 _mousePos = Input.mousePosition;

            Ray _ray = _cam.ScreenPointToRay(_mousePos); // Sug�r lek�r�se

            // Ray _otherRay = new Ray(transform.position, transform.forward);  L�v�s sug�r l�trehoz�si tipp

            // Sug�rvet�s
            bool _doesHit = Physics.Raycast(_ray, out RaycastHit _hit, 100, _raycastLayers);

            if (_doesHit)
            {
                _lastRayHit = _hit.point;
                transform.position = _lastRayHit;
                _partyclesystem.Play();
                Debug.Log(_hit.collider.name + "   " + _hit.point);
                _Explode(_lastRayHit);

            }
        }
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_lastRayHit, 0.2f);
    }
    void _Explode(Vector3 _pos)
    {
        for (int _i = 0; _i < _rigidbodies.Length; _i++)
        {
            // V�gigmegy az �sszes rigibodyn
            Rigidbody _rb = _rigidbodies[_i];

            // ExpOne(_pos, _rb);
            _rb.AddExplosionForce(_maxForce, _pos, _range, _upward, ForceMode.Impulse);


        }
    }

      void ExpOne(Vector3 _pos, Rigidbody _rb)
    {
        Vector3 _distanceVect = _rb.transform.position - _pos;
        float _distance = _distanceVect.magnitude;    //T�vols�g
        Vector3 _direction = _distanceVect / _distance;  // Ir�ny

        if (_distance < _range)  // ha tartom�nyon bel�l vagyunk
        {
            // t�vols�gar�nyos er�
            float _force = _maxForce * (_range - _distance) / _range;

            _rb.AddForce(_force * _direction, ForceMode.Impulse);
        }
    }
}
