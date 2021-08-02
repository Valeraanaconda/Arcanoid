using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    private void Update()
    {
        transform.Translate(Vector3.right * (speed * Input.GetAxis("Horizontal") * Time.deltaTime));
        var position = transform.position;
        position = new Vector3(Mathf.Clamp(position.x,-2.30f,2.30f), position.y, position.z);
        transform.position = position;
    }
}
