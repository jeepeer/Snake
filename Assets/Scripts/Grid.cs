using UnityEngine;

public class Grid : MonoBehaviour // CreateGrid ? 
{
    public int rows = 10;
    public int collumns = 10;
    public int[,] grid;

    //[SerializeField] private GameObject tile;
    
    private void Start()
    {
        BuildGrid();
    }

    private void BuildGrid() 
    {
        grid = new int[rows, collumns];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < collumns; j++)
            {
                if (TryGetComponent(out Tiles tiles))
                {
                    tiles.SpawnTiles(i,j);
                }
            }
        }
    }
    
}
