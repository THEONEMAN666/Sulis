
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    [SerializeField] Space space;
    
    void Update()
    {
        float rotation = angularSpeed * Time.deltaTime; // Egyenletesen változó mozgás a képfrissítés függvényében -> Time.deltaTime
        transform.Rotate(0,rotation, 0, space);
        

    }
}
