using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody m_Rigidbody;
    public float m_Speed = 5f;
    public Vector3 inn;
    void Start()
    {
        
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Vector3 m_Input = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        m_Rigidbody.MovePosition(transform.position + m_Input * Time.deltaTime * m_Speed);
        inn = m_Input;
    }
}