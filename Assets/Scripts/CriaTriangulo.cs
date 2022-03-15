using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]

public class CriaTriangulo: MonoBehaviour
{
    public bool sharedVertices = false;
    // Define as pontas do triangulo
    Vector3 p0 = new Vector3(0, 0, 0);
    Vector3 p1 = new Vector3(1, 0, 0);
    Vector3 p2 = new Vector3(0.5f, 0, Mathf.Sqrt(0.75f));
    Vector3 p3 = new Vector3(0.5f, Mathf.Sqrt(0.75f), Mathf.Sqrt(0.75f) / 3);
    // Cria um novo mesh
    Mesh mesh;

    // 
    public Vector3[] getVectors()
    {
        Vector3[] vertex = new Vector3[] { p0, p1, p2, p3 };
        return vertex;
    }

    public void Rebuild()
    {
        // Pega o meshFilter do objeto
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        // Caso não exista algum, dispara um erro.
        if (meshFilter == null)
        {
            Debug.LogError("MeshFilter not found!");
            return;
        }
        // Se a mesh não existir
        if (mesh == null)
        {
            // Cria uma nova mesh
            meshFilter.mesh = new Mesh();
        }
        // Define que qualquer modificação vai relfetir em todas as mesh's
        mesh = meshFilter.sharedMesh;
        // Limpa todos os dados da mesh
        mesh.Clear();
        if (sharedVertices)
        {
            mesh.vertices = new Vector3[] { p0, p1, p2, p3 };
            mesh.triangles = new int[]{
                0,1,2,
                0,2,3,
                2,1,3,
                0,3,1
            };
            // basically just assigns a corner of the texture to each vertex
            mesh.uv = new Vector2[]{
                new Vector2(0,0),
                new Vector2(1,0),
                new Vector2(0,1),
                new Vector2(1,1),
            };
        }
        else
        {
            mesh.vertices = new Vector3[]{
                p0,p1,p2,
                p0,p2,p3,
                p2,p1,p3,
                p0,p3,p1
            };
            mesh.triangles = new int[]{ // 3 vertices por face
                0,1,2,
                3,4,5,
                6,7,8,
                9,10,11
            };

            Vector2 uv0 = new Vector2(0, 0);
            Vector2 uv1 = new Vector2(1, 0);
            Vector2 uv2 = new Vector2(0.5f, 1);

            mesh.uv = new Vector2[]{
                uv0,uv1,uv2,
                uv1,uv0,uv1,
                uv2,uv1,uv0,
                uv1,uv2,uv0
            };
        }

        mesh.RecalculateNormals();
        mesh.RecalculateBounds();
        // Otimiza a mesh
        mesh.Optimize();
    }
    // No primeiro frame executa a construção do triangulo
    void Start()
    {
        Rebuild();
    }
}