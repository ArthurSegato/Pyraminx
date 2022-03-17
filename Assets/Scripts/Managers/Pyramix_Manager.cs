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
        // Cria os triangulos e os pivores
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
        /* 
            Define as posições dos triangulos
        */
        // Amarelo (Frente)
        pivoArray[1].transform.position = new Vector3(1, 0, 0);
        pivoArray[2].transform.position = new Vector3(2, 0, 0);
        pivoArray[3].transform.position = new Vector3(0.5f, 0.194f, 0.07f);
        pivoArray[3].transform.Rotate(36.1f, 0.0f, 180.0f);
        pivoArray[4].transform.position = new Vector3(1.5f, 0.194f, 0.07f);
        pivoArray[4].transform.Rotate(36.1f, 0.0f, 180.0f);
        pivoArray[5].transform.position = new Vector3(0.5f, 0.856f, 0.289f);
        pivoArray[6].transform.position = new Vector3(1.5f, 0.856f, 0.289f);
        pivoArray[7].transform.position = new Vector3(1f, 1.05f, 0.35f);
        pivoArray[7].transform.Rotate(37.2f, 0.0f, 180.0f);
        pivoArray[8].transform.position = new Vector3(1, 1.72f, 0.577f);
        // Vermelho (Baixo)
        pivoArray[9].transform.position = new Vector3(0.5f, 0, 0.3f);
        pivoArray[9].transform.Rotate(0.0f, 180.0f, 0f);
        pivoArray[10].transform.position = new Vector3(1.5f, 0, 0.3f);
        pivoArray[10].transform.Rotate(0.0f, 180.0f, 0f);
        pivoArray[11].transform.position = new Vector3(0.5f, 0, 0.86f);
        pivoArray[12].transform.position = new Vector3(1.5f, 0, 0.86f);
        pivoArray[13].transform.position = new Vector3(1.0f, 0, 1.165f);
        pivoArray[13].transform.Rotate(0.0f, 180.0f, 0f);
        pivoArray[14].transform.position = new Vector3(1.0f, 0, 1.72f);
        // Azul
        
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