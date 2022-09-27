
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] float angularSpeed;
    
    void Update()
    {
        float rotation = angularSpeed * Time.deltaTime; // Egyenletesen v�ltoz� mozg�s a k�pfriss�t�s f�ggv�ny�ben -> Time.deltaTime
        transform.Rotate(0,rotation, 0);
        

    }
}
