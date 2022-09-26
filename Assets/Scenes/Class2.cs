using UnityEngine;

 class Class2 : MonoBehaviour
{
 [SerializeField] float number;                    
 [SerializeField] float round, roundUp, roundDown;
 [SerializeField] int a, b, c, d, e;   
 [SerializeField] int min, max;
    private void OnValidate()
    {
        round = Mathf.Round(number);
        roundUp = Mathf.Ceil(number);
        roundDown = Mathf.Floor(number);
        min = Mathf.Min(a, b, c, d, e);
        max = Mathf.Max(a, b, c, d, e);


    }

}
