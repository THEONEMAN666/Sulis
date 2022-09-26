using UnityEngine;

public class Boolok : MonoBehaviour
{
    [SerializeField] int lekvar;

    [SerializeField] bool divisibleWith7;
    [SerializeField] bool divisbleWith15;
    [SerializeField] bool divisibleWith99;

    private void OnValidate()
    {
        int remainder = lekvar % 7;
        divisibleWith7 = remainder == 0;
        divisibleWith99 = lekvar % 99 == 0;
        divisbleWith15 = lekvar % 15 == 0; 
    }






}
