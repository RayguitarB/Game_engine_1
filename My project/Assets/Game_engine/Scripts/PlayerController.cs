using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private float currentSpeed = 0.0f;

    void Start()
    {

    }
void Update()
{
    // 이동 벡터 계산
    Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            movement += Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1); // X축 뒤집기
    }

        if (Input.GetKey(KeyCode.D))
        {
            movement += Vector3.right;
            transform.localScale = new Vector3(1, 1, 1); // 원래 크기
    }
        
        // 속도 계산: 이동 중이면 moveSpeed, 아니면 0
        if (Input.GetKey(KeyCode.LeftShift))
    {
        currentSpeed = moveSpeed * 5f;
        Debug.Log("달리기 모드 활성화!");
    }
        else {
            currentSpeed = movement != Vector3.zero ? moveSpeed : 0f;
        }
    // 실제 이동 적용
        if (movement != Vector3.zero)
        {
            transform.Translate(movement * currentSpeed * Time.deltaTime);
        }

    
}
}