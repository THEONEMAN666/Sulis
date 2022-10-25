
using UnityEngine;

class ClickExplosion : MonoBehaviour

// ctrl+k+d = automatikus igazítás
// ctrl+rr = mindent átnevez egyszerre
// for ciklus alapkoncepció kiírása tab*2
// ctrl+space = metódus ajánlatok kérése
{
    [SerializeField] float _maxForce;
    [SerializeField] float _range;
    [SerializeField] float _upward;
    [SerializeField] LayerMask _raycastLayers;
    [SerializeField] ParticleSystem _partyclesystem;

    Vector3 _lastRayHit;
    Rigidbody[] _rigidbodies; // Tömbösítés [] bármivel végrehajtható


    void Start()
    {
        _rigidbodies = FindObjectsOfType<Rigidbody>();

    }

    void Update()
    {
        // Kattintásra
        if (Input.GetMouseButtonDown(0))
        {

            Camera _cam = Camera.main;

            Vector3 _mousePos = Input.mousePosition;

            Ray _ray = _cam.ScreenPointToRay(_mousePos); // Sugár lekérése

            // Ray _otherRay = new Ray(transform.position, transform.forward);  Lövés sugár létrehozási tipp

            // Sugárvetés
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
            // Végigmegy az összes rigibodyn
            Rigidbody _rb = _rigidbodies[_i];

            // ExpOne(_pos, _rb);
            _rb.AddExplosionForce(_maxForce, _pos, _range, _upward, ForceMode.Impulse);


        }
    }

      void ExpOne(Vector3 _pos, Rigidbody _rb)
    {
        Vector3 _distanceVect = _rb.transform.position - _pos;
        float _distance = _distanceVect.magnitude;    //Távolság
        Vector3 _direction = _distanceVect / _distance;  // Irány

        if (_distance < _range)  // ha tartományon belül vagyunk
        {
            // távolságarányos erõ
            float _force = _maxForce * (_range - _distance) / _range;

            _rb.AddForce(_force * _direction, ForceMode.Impulse);
        }
    }
}
