// ============================================================
// H2V_Metalab_VR — Avançado
// Script: SensorProximidade.cs
// Objeto: Sensor_MQ8
// Função: Detecta quando o jogador se aproxima do sensor e
//         exibe mensagem de alerta na UI, simulando detecção
//         de gás H₂ pelo H2VSENSE. Também pode ser testado
//         pelo script TesteInteracoes (tecla [4]).
// Autor: Ednardo Pinheiro Peixoto
// Residência TIC 29 — Web 3.0 | Maio 2026
// ============================================================

using UnityEngine;
using UnityEngine.UI;

public class SensorProximidade : MonoBehaviour
{
    [Header("Distância de Detecção")]
    public float raioDeteccao = 2.5f;

    [Header("UI — Painel de Alerta")]
    public GameObject painelAlerta;
    public Text       textoAlerta;

    [Header("Mensagens")]
    public string msgDetectado = "⚠️ SENSOR MQ-8: H₂ detectado!\nAproximar com cautela.";
    public string msgNormal    = "✅ Sensor MQ-8: Nível normal.";

    [Header("Cor do Sensor")]
    public Color corAtivo   = Color.yellow;
    public Color corInativo = Color.white;

    private Transform jogador;
    private bool      jogadorProximo = false;
    private Renderer  rend;
    private Material  mat;

    void Start()
    {
        rend = GetComponent<Renderer>();
        mat  = rend.material;

        GameObject xrOrigin = GameObject.Find("XR Origin (VR)");
        if (xrOrigin != null)
            jogador = xrOrigin.transform;
        else
            Debug.LogWarning("[SensorProximidade] XR Origin não encontrado!");

        if (painelAlerta != null)
            painelAlerta.SetActive(false);
    }

    void Update()
    {
        if (jogador == null) return;

        float distancia   = Vector3.Distance(transform.position, jogador.position);
        bool  estaProximo = distancia <= raioDeteccao;

        if (estaProximo && !jogadorProximo)
            EntrarZona();
        else if (!estaProximo && jogadorProximo)
            SairZona();

        jogadorProximo = estaProximo;
    }

    // MÉTODO PÚBLICO — chamado pelo TesteInteracoes (tecla 4)
    public void SimularProximidade(bool ativo)
    {
        if (ativo && !jogadorProximo)
        {
            jogadorProximo = true;
            EntrarZona();
        }
        else if (!ativo && jogadorProximo)
        {
            jogadorProximo = false;
            SairZona();
        }
    }

    private void EntrarZona()
    {
        Debug.Log("[H2VSENSE] 🔴 Sensor MQ-8 ativado — H₂ detectado!");
        mat.color = corAtivo;
        if (painelAlerta != null) painelAlerta.SetActive(true);
        if (textoAlerta  != null) textoAlerta.text = msgDetectado;
    }

    private void SairZona()
    {
        Debug.Log("[H2VSENSE] 🟢 Sensor MQ-8 — nível normal.");
        mat.color = corInativo;
        if (textoAlerta  != null) textoAlerta.text = msgNormal;
        if (painelAlerta != null) Invoke("OcultarPainel", 2f);
    }

    private void OcultarPainel()
    {
        if (painelAlerta != null)
            painelAlerta.SetActive(false);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, raioDeteccao);
    }
}
