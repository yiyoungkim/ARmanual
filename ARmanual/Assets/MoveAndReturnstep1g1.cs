using UnityEngine;

public class MoveAndReturnstep1g1 : MonoBehaviour
{
    public Vector3 targetPosition = new Vector3(-0.2041f, 0f, 0f);
    public Vector3 targetRotation = new Vector3(10f, -90f, 0f);
    public float moveSpeed = 1.0f; 
    public float rotateSpeed = 1.0f; 
    public float appearanceDuration = 2.0f; 
    public float delayBeforeAppearance = 0.0f; 

    private Vector3 initialPosition; 
    private float elapsedTime = 0f; 
    private bool appeared = false; 

    void Start()
    {
        
        initialPosition = transform.position;

    }

    void Update()
    {
        
        
        if (!appeared)
        {
            transform.position = targetPosition;
            if (elapsedTime < delayBeforeAppearance)
            {
                elapsedTime += Time.deltaTime;
            }
            else
            {
                
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
