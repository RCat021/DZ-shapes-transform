using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _scalingDirection;

    private void Update()
    {
        transform.localScale += _scalingDirection * Time.deltaTime;
    }
}
