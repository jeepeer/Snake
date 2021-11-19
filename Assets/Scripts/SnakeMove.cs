using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SnakeMove : MonoBehaviour
{
    [SerializeField] private float timeBeforeMove;
    public Vector3 previousPosition;
    private float zero = 0;
    private Vector3 currentDirection;
    private SnakeGrow snakeGrow;
    
    private void Start()
    {
        snakeGrow = GetComponent<SnakeGrow>();
        currentDirection = Vector3.forward;
    }
    
    private void Update()
    {
        ProcessDirection();
        MoveTimer();
    }
    
    private void MoveTimer()
    {
        zero += Time.deltaTime;
        if (zero >= timeBeforeMove)
        {
            ProcessDirection();
            MoveForward(currentDirection);
            zero = 0;
        } 
    }

    private void MoveForward(Vector3 direction)
    {
        previousPosition = transform.position;
        transform.position += direction;
        MoveSnakeParts(previousPosition);
    }
    
    private void MoveSnakeParts(Vector3 position) // try get component for consistancy
    {
        for (int i = 0; i < snakeGrow.SnakeList.Count; i++)
        {
            (snakeGrow.SnakeList[i].transform.position, position) =
                (position, snakeGrow.SnakeList[i].transform.position);
        }
    }
    
    private void ProcessDirection()
    {
        VerticalMovement();
        HorizontalMovement();
    }

    private void VerticalMovement()
    {
        if (Input.GetKeyDown(KeyCode.W) && currentDirection != Vector3.back)
        {
            currentDirection = Vector3.forward;
        }
        else if (Input.GetKeyDown(KeyCode.S) && currentDirection != Vector3.forward)
        {
            currentDirection = Vector3.back;
        }
    }

    private void HorizontalMovement()
    {
        if (Input.GetKeyDown(KeyCode.A) && currentDirection != Vector3.right)
        {
            currentDirection = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && currentDirection != Vector3.left)
        {
            currentDirection = Vector3.right;
        }
    }
}
