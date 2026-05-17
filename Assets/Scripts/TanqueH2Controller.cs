// ============================================================
// H2V_Metalab_VR — Avançado
// Script: TanqueH2Controller.cs
// Objeto: Tanque H2 (Cylinder)
// Função: Ao clicar no tanque, executa animação de pulsação
//         (escala) e ativa sistema de partículas simulando
//         vapor/gás H₂, com log de pressão no Console.
// Autor: Ednardo Pinheiro Peixoto
// Residência TIC 29 — Web 3.0 | Maio 2026
// ============================================================

using UnityEngine;
using System.Collections;

public class TanqueH2Controller : MonoBehaviour
{
    // ── CONFIGURAÇÕES PÚBLICAS (editáveis no Inspector) ──────
    [Header("Animação de Pulsação")]
    public float escalaMaxima    = 1.15f;    // Escala no pico da animação
    public float duracaoAnimacao = 0.4f;     // Duração em segundos
    public int   numeroPulsacoes = 2;        // Quantas vezes pulsa

    [Header("Partículas")]
    public ParticleSystem particulasVapor;   // Arraste o Particle System aqui

    [Header("UI — Texto de Pressão")]
    public UnityEngine.UI.Text textoPressao; // Texto na UI (opcional)

    [Header("Cor do Tanque")]
    public Color corNormal  = new Color(0.2f, 0.4f, 0.8f); // Azul
    public Color corAtivado = new Color(0.1f, 0.7f, 0.9f); // Azul claro

    // ── VARIÁVEIS PRIVADAS ───────────────────────────────────
    private Vector3   escalaOriginal;
    private Renderer  rend;
    private Material  mat;
    private bool      animando = false;      // Evita cliques durante animação

    // ─────────────────────────────────────────────────────────
    void Start()
    {
        rend           = GetComponent<Renderer>();
        mat            = rend.material;
        escalaOriginal = transform.localScale; // Salva escala original

        // Define cor inicial do tanque
        mat.color = corNormal;

        // Garante que partículas começam paradas
        if (particulasVapor != null)
            particulasVapor.Stop();
    }

    // ─────────────────────────────────────────────────────────
    // MÉTODO PÚBLICO — chamado pelo OnSelect do XR Interactable
    // ─────────────────────────────────────────────────────────
    public void AtivarTanque()
    {
        // Evita ativar novamente durante animação
        if (animando) return;

        Debug.Log("[H2VSENSE] 🔵 Tanque H₂ ativado — verificando pressão...");
        StartCoroutine(AnimacaoPulsacao());
    }

    // ─────────────────────────────────────────────────────────
    // Coroutine: animação de pulsação do tanque
    // ─────────────────────────────────────────────────────────
    private IEnumerator AnimacaoPulsacao()
    {
        animando = true;
        mat.color = corAtivado;

        // Ativa partículas de vapor
        if (particulasVapor != null)
            particulasVapor.Play();

        // Simula leitura de pressão
        float pressaoSimulada = Random.Range(120f, 350f); // bar
        string statusPressao  = pressaoSimulada > 250f
            ? "⚠️ PRESSÃO ELEVADA"
            : "✅ PRESSÃO NORMAL";

        // Atualiza UI de pressão se configurada
        if (textoPressao != null)
            textoPressao.text = $"🔵 Tanque H₂\nPressão: {pressaoSimulada:F0} bar\n{statusPressao}";

        Debug.Log($"[H2VSENSE] Pressão do tanque: {pressaoSimulada:F0} bar — {statusPressao}");

        // Executa N pulsações
        for (int i = 0; i < numeroPulsacoes; i++)
        {
            // Expande
            yield return StartCoroutine(
                AnimarEscala(escalaOriginal, escalaOriginal * escalaMaxima, duracaoAnimacao / 2f)
            );

            // Contrai
            yield return StartCoroutine(
                AnimarEscala(escalaOriginal * escalaMaxima, escalaOriginal, duracaoAnimacao / 2f)
            );
        }

        // Para partículas após animação
        if (particulasVapor != null)
            particulasVapor.Stop();

        // Restaura cor original
        mat.color = corNormal;
        animando  = false;
    }

    // ─────────────────────────────────────────────────────────
    // Coroutine auxiliar: interpola suavemente entre escalas
    // ─────────────────────────────────────────────────────────
    private IEnumerator AnimarEscala(Vector3 de, Vector3 para, float duracao)
    {
        float tempo    = 0f;

        while (tempo < duracao)
        {
            tempo += Time.deltaTime;
            float t = Mathf.SmoothStep(0f, 1f, tempo / duracao); // Suavização
            transform.localScale = Vector3.Lerp(de, para, t);
            yield return null; // Aguarda próximo frame
        }

        transform.localScale = para; // Garante valor final exato
    }

    // ─────────────────────────────────────────────────────────
    // Clique do mouse no Editor (testes sem VR)
    // ─────────────────────────────────────────────────────────
    private void OnMouseDown()
    {
        AtivarTanque();
    }

    // ─────────────────────────────────────────────────────────
    // Gizmo: mostra esfera de interação no Editor
    // ─────────────────────────────────────────────────────────
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0.2f, 0.4f, 0.8f, 0.3f);
        Gizmos.DrawSphere(transform.position, 1f);
    }
}
