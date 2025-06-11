using UnityEngine;

public class HelloBanana : MonoBehaviour
{
    public Transform m_whereToSpawn;
    public GameObject m_prefabToSpawn;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject go = Instantiate(m_prefabToSpawn, transform.position, Quaternion.identity);
    }
}
