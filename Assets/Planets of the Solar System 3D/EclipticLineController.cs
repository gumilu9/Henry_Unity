using UnityEngine;

public class EclipticLineController : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int segmentCount = 50;
    public float radius = 5.0f;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = segmentCount + 1; // 设置positionCount
        lineRenderer.useWorldSpace = false;
        CreatePoints();
    }

    void CreatePoints()
    {
        float x, y, z;
        float angleStep = 180f / segmentCount;
        float angle = 0f; // 从-90度到90度

        for (int i = 0; i <= segmentCount; i++)
        {
            x = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;
            y = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;

            lineRenderer.SetPosition(i, new Vector3(x, y, 0));
            angle += angleStep;
        }
    }
}