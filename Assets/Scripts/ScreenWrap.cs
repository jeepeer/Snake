using UnityEngine;

public class ScreenWrap : Grid
{
    void Update()
    {
        HorizontalScreenWrap();
        VerticalScreenWrap();
    }
    private void HorizontalScreenWrap()
    {
        Vector3 snakePosition = transform.position;
        
        if (transform.position.x > rows - 1 ) 
        {
            HorizontalWrappedPosition(snakePosition.z, 1); 
        }
        else if (transform.position.x < 0) 
        { 
            HorizontalWrappedPosition(snakePosition.z,rows);
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
        
        if (transform.position.z > collumns-1) 
        { 
            VerticalWrappedPosition(snakePosition.x, 1);
        }
        else if (transform.position.z < 0)
        {
            VerticalWrappedPosition(snakePosition.x, collumns);
        }
    }

    private void VerticalWrappedPosition(float savedFloatValue, float gridFloatValue)
    {
        Vector3 wrappedPosition = new Vector3(savedFloatValue, 0, (gridFloatValue -1));
        
        transform.position = wrappedPosition;
    }
}
