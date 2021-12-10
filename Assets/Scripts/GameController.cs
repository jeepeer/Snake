using UnityEngine;

public class GameController : MonoBehaviour
{
    public int width = 10;
    public int height = 10;
    public Vector3[,] grid;
    public Vector3[] tilePositions;
    private Vector3 fruitPosition;
    private Vector3 gridPositionToMoveTo;
    private void Awake()
    {
        tilePositions = new Vector3[width * height];
        BuildGrid();
    }

    private void BuildGrid() 
    {
        grid = new Vector3[width, height];
        int n = 0;
        
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                grid[i,j] = new Vector3(i,0,j);
                tilePositions[n] = new Vector3(i, 0, j);
                n++;
                PlaceTiles(i,j);
            }
        }
    }

    public Vector3 NextGridPosition(Vector3 futurePosition)
    {
        int futureX = (int)futurePosition.x;
        int futureZ = (int)futurePosition.z;
        
        gridPositionToMoveTo = grid[futureX, futureZ];
        
        return WrapSnakeAroundScreen(gridPositionToMoveTo);
    }

    private Vector3 WrapSnakeAroundScreen(Vector3 futurePosition)
    {
        if (futurePosition.x <= 0)
        {
            futurePosition.x = width -1;
        }
        else if (futurePosition.x >= width -1)
        {
            futurePosition.x = 0;
        }
        
        if (futurePosition.z <= 0)
        {
            futurePosition.z = height -1;
        }
        else if (futurePosition.z >= height -1)
        {
            futurePosition.z = 0;
        }

        return futurePosition;
    }
    

    private void PlaceTiles(int x, int z)
    {
        if (TryGetComponent(out Tiles tiles))
        {
            tiles.SpawnTiles(x,z);
        }
    }
}
