using UnityEngine;

public class MoveAndReturnstep1g4 : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(-0.3041f, 0f, 0f);
    public Vector3 targetRotation = new Vector3(10f, -90f, 0f);
    public float moveSpeed = 1.0f; // 이동 속도 조절
    public float rotateSpeed = 1.0f; // 회전 속도 조절
    public float appearanceDuration = 2.0f; // 나타나는 데 걸리는 시간 (초)
    public float delayBeforeAppearance = 4.0f; // 나타나기 전 대기 시간 (초)

    private Vector3 initialPosition; // 초기 위치
    private float elapsedTime = 0f; // 경과 시간
    private bool appeared = false; // 나타났는지 여부

    void Start()
    {
        // 초기 위치 설정
        initialPosition = transform.position;

    }

    void Update()
    {
        if (!appeared)
        {
            transform.position = targetPosition;
            // 대기 시간이 지난 후에 나타나기
            if (elapsedTime < delayBeforeAppearance)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                // 나타난 후 초기 위치로 돌아가기
                if (elapsedTime < delayBeforeAppearance + appearanceDuration)
                {
                    transform.position = Vector3.Lerp(targetPosition, initialPosition, (elapsedTime - delayBeforeAppearance) / appearanceDuration);
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
}