
using UnityEngine;

public class Lerpractice : MonoBehaviour
{
    [SerializeField] Color colorA, colorB;
    [SerializeField] Vector3 posA, posB;
    [SerializeField, Range(0,1)]float t;

    [SerializeField] Vector3 lerpos;
    [SerializeField] Color lerpColor;


   


    private void OnValidate()
    {
        lerpColor = Color.LerpUnclamped (colorA, colorB, t);
        lerpos = Vector3.Lerp(posA, posB, t);

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = colorA;
        Gizmos.DrawWireSphere(posA, 0.1f);
        Gizmos.color = colorB;
        Gizmos.DrawWireSphere(posB, 0.1f);
    }
}
