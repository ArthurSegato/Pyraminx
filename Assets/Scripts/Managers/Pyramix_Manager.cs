using UnityEngine;
public class Pyramix_Manager : MonoBehaviour
{
    // Quantidade de triangulos a serem criados
    public int numeroDeTriangulos = 0;
    // Qual o triangulo base que vai ser clonado
    public GameObject triangulo;
    // Array de triangulos
    public GameObject[] trianguloArray;
    // Array de pivores
    public GameObject[] pivoArray;
    // Use this for initialization
    void Start()
    {
        trianguloArray = new GameObject[numeroDeTriangulos];
        pivoArray = new GameObject[numeroDeTriangulos];
        for (int i = 0; i < numeroDeTriangulos; i++)
        {
            // Cria um pivo
            pivoArray[i] = new GameObject();
            // Define a posição inicial de cada pivo
            pivoArray[i].transform.position = new Vector3(0, 0, 0);
            // Da um nome para cada pivo
            pivoArray[i].name = "Pivo " + i;
            // Cria um triangulo
            GameObject trianguloClone = Instantiate(triangulo, new Vector3(-0.5f, -0.28f, -0.28f), Quaternion.identity);
            // Define a escala do triangulo criado
            trianguloClone.transform.localScale = Vector3.one;
            // Enfia o triangulo no array
            trianguloArray[i] = trianguloClone;
            // Da um nome pro triangulo
            trianguloArray[i].name = "Triangulo " + i;
            // Envia o triangulo no pivo            
            trianguloArray[i].transform.parent = pivoArray[i].transform;
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        //vetGameObj[3].transform.RotateAround(transform.position, Vector3.forward, 5f);
        //cria um gameobject: Pai. Tem eixo de rotacao
        //por o objeto como filho deste gameobject
        //rotaciona o gameObjet(pai): consequencia o filho rotaciona
        //Instantiate(Object original, Vector3 position, Quaternion rotation, Transform parent);
        //pai.transform.Rotate(Vector3.right * 5);
        //vetGameObj[4].transform.Rotate((Vector3.right + Vector3.up) * 5);
    }
}