
using UnityEngine;

 class Autodestroyer : MonoBehaviour

  {

    [SerializeField] float _destructiontime;

    float startTime;
    
    void Start()
    {
        startTime = Time.time;
    }

    
    void Update()
    {
        float _currenttime = Time.time;

        if (startTime + _destructiontime < _currenttime)
        {
            Destroy(gameObject);
        }
    }
}
