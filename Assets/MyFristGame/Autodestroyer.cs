
using UnityEngine;

 class Autodestroyer : MonoBehaviour

  {

    [SerializeField] float _destructiontime;

    float startTime;

    [SerializeField] GameObject go;
    [SerializeField] MonoBehaviour mb;
    
    void Test()
    {
        startTime = Time.time;

        go.SetActive(true);// GameObject be

        go.SetActive(false); // GameObject ki

        Debug.Log("Be van kapcsolva a GameObject és minden szülõ:" + go.activeInHierarchy);
        Debug.Log("Be van kapcsolva a GameObject és minden szülõ:" + go.activeSelf);

        mb.enabled = false;// komponensek ki

        mb.enabled = true;// komponensek be

        Debug.Log("Be van kapcsolva:" + mb.enabled);
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
