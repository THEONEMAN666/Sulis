using UnityEngine;

class HaziFeladat : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] bool divisibleWith7;
    [SerializeField] bool divisibleWith15;
    [SerializeField] bool divisibleWith99; 

    void OnValidate()
    {
        int remainder = number % 7;       
        divisibleWith7 = remainder == 0;
        divisibleWith15 = number % 15 == 0;
        divisibleWith99 = number % 99 == 0;

    }


}
