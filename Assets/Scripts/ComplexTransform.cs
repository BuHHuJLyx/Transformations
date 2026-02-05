using UnityEngine;

public class ComplexTransform : MonoBehaviour
{
    private float _moveSpeed = 2f;
    private float _rotateSpeed = 45f;
    private float _scaleSpeed = 0.5f;

    private void Update()
    {
        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}