
using UnityEngine;

public class StepCount : MonoBehaviour
{
    [SerializeField] Vector2 a, b;
    [SerializeField] int stepCount;
    [SerializeField] Vector2 step;


    private void OnValidate()
    {
        stepCount = Mathf.CeilToInt(Vector2.Distance(a, b)); // 1 egys�gnyi l�p�s, �nn�ll�an alak�t int-be
        step = (b - a) / stepCount; // l�p�sek sz�m�nak meghat�roz�sa


    }
}
