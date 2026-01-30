using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    [Header("Settings")]
    public GameObject pixelPrefab; // Hier das Prefab im Inspector zuweisen
    public int rows = 10; // 
    public int columns = 7; // 

    // Ein Array, um die Referenzen auf die UI-Bilder zu speichern
    private Image[,] pixelImages;

    void Awake()
    {
        CreateGrid();
    }

    void CreateGrid()
    {
        pixelImages = new Image[rows, columns];

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < columns; c++)
            {
                // Pixel erstellen als Kind dieses Objekts
                GameObject newPixel = Instantiate(pixelPrefab, transform);
                newPixel.name = $"Pixel_{r}_{c}";

                // Referenz für später (Feature 8) speichern
                pixelImages[r, c] = newPixel.GetComponent<Image>();
            }
        }
    }
}