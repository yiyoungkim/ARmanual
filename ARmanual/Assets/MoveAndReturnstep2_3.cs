using UnityEngine;

public class MoveAndReturnstep2_3 : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(0.2041f, 0f, 0f);
    public float moveSpeed = 1.0f; // 이동 속도 조절
    public float appearanceDuration = 2.0f; // 나타나는 데 걸리는 시간 setting

    private Vector3 initialPosition; // 초기 위치 저장
    private float elapsedTime = 0f; // 경과 시간 확인
    private bool appeared = false; // 나타났는지 여부 확인

    void Start()
    {
        // 초기 위치 설정 저장
        initialPosition = transform.position;
    }

    void Update()
    {
        if (!appeared)
        {
            // 나타난 후 초기 위치로 돌아가도록 성절
            if (elapsedTime < appearanceDuration)
            {
                transform.position = Vector3.Lerp(targetPosition, initialPosition, elapsedTime / appearanceDuration);
                elapsedTime += Time.deltaTime;
            }
            else
            {
                transform.position = initialPosition;
                appeared = true;
            }
        }

    }
}