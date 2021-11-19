using UnityEngine;

public class ScreenWrap : GameController
{
    void Update()
    {
        HorizontalScreenWrap();
        VerticalScreenWrap();
    }
    private void HorizontalScreenWrap()
    {
        Vector3 snakePosition = transform.position;
        
        if (snakePosition.x > width -1) 
        {
            HorizontalWrappedPosition(snakePosition.z, 1); 
        }
        else if (snakePosition.x < 0) 
        { 
            HorizontalWrappedPosition(snakePosition.z,width);
        }
    }
    
    private void HorizontalWrappedPosition(float savedFloatValue, float gridFloatValue)
    {
        Vector3 wrappedPosition = new Vector3((gridFloatValue -1), 0, savedFloatValue);
        
        transform.position = wrappedPosition;
    }
    
    private void VerticalScreenWrap()
    {
        Vector3 snakePosition = transform.position;
        
        if (snakePosition.z > height -1) 
        { 
            VerticalWrappedPosition(snakePosition.x, 1);
        }
        else if (snakePosition.z < 0)
        {
            VerticalWrappedPosition(snakePosition.x, height);
        }
    }

    private void VerticalWrappedPosition(float savedFloatValue, float gridFloatValue)
    {
        Vector3 wrappedPosition = new Vector3(savedFloatValue, 0, (gridFloatValue -1));
        
        transform.position = wrappedPosition;
    }
}
