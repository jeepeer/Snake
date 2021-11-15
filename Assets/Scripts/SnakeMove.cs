using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class SnakeMove : MonoBehaviour
{
    [SerializeField] private float timeBeforeMove;
    private float zero = 0;
    private int rotationDegrees = 90;

    public Vector3 previousPosition;

    private SnakeGrow snakeGrow;

    private void Start()
    {
        snakeGrow = GetComponent<SnakeGrow>();
    }
    
    private void Update()
    {
        MoveTimer();
        ProcessRotation();
    }
    
    private void MoveTimer()
    {
        zero += Time.deltaTime;
        if (zero >= timeBeforeMove) // refractor ? maybe not 
        {
            MoveForward();
            zero = 0;
        } 
    }

    private void MoveForward()
    {
        previousPosition = transform.position;
        transform.position += transform.forward;
        
        //MoveSnakeParts(previousPosition);
        for (int i = 0; i < snakeGrow.SnakeList.count; i++)
        {
            (snakeGrow.SnakeList[i].transform.position, previousPosition) =
                (previousPosition, snakeGrow.SnakeList[i].transform.position);
        }
    }

    /*private void MoveSnakeParts(Vector3 position)
    {
        for (int i = 0; i < snakeGrow.SnakeList.count; i++)
        {
            (snakeGrow.SnakeList[i].transform.position, position) =
                (position, snakeGrow.SnakeList[i].transform.position);
        }
    }*/
    
    private void ProcessRotation()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            RotateLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            RotateRight();
        }
    }

    private void RotateLeft()
    {
        transform.Rotate(Vector3.down, rotationDegrees);
    }
    private void RotateRight()
    {
        transform.Rotate(Vector3.up, rotationDegrees);
    }
}
