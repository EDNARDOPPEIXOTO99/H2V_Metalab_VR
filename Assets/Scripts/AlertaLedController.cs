// ============================================================
// H2V_Metalab_VR — Avançado
// Script: AlertaLedController.cs
// Objeto: Alerta_Led (Sphere)
// Função: Ao clicar no LED, alterna entre estado NORMAL (verde)
//         e estado ALERTA (vermelho piscando), simulando o
//         comportamento real do sensor H2VSENSE.
// Autor: Ednardo Pinheiro Peixoto
// Residência TIC 29 — Web 3.0 | Maio 2026
// ============================================================

using UnityEngine;

public class AlertaLedController : MonoBehaviour
{
    // ── CONFIGURAÇÕES PÚBLICAS (editáveis no Inspector) ──────
    [Header("Cores do LED")]
    public Color corNormal  = Color.green;   // Estado seguro
    public Color corAlerta  = Color.red;     // Estado de alerta

    [Header("Velocidade do Pisca-Pisca")]
    public float velocidadePisca = 3f;       // Hz do piscar em alerta

    [Header("Componentes")]
    public Light luzLED;                     // Luz pontual do LED (opcional)

    // ── VARIÁVEIS PRIVADAS ───────────────────────────────────
    private bool      emAlerta   = false;    // Estado atual do LED
    private Renderer  rend;                  // Renderer do objeto
    private Material  mat;                   // Material do objeto
    private float     tempoPisca = 0f;       // Contador do piscar
    private bool      visivelPisca = true;   // Controle do piscar

    // ─────────────────────────────────────────────────────────
    void Start()
    {
        // Obtém o Renderer e cria uma cópia do material
        // para não afetar outros objetos que usam o mesmo material
        rend = GetComponent<Renderer>();
        mat  = rend.material;

        // Define cor inicial como verde (estado normal)
        AplicarCorNormal();
    }

    // ─────────────────────────────────────────────────────────
    void Update()
    {
        // Só executa o piscar quando estiver em estado de alerta
        if (emAlerta)
        {
            tempoPisca += Time.deltaTime * velocidadePisca;

            // Alterna visibilidade do LED para criar efeito de piscar
            if (tempoPisca >= 1f)
            {
                tempoPisca    = 0f;
                visivelPisca  = !visivelPisca;

                // Aplica cor vermelha ou apaga conforme estado do piscar
                mat.color = visivelPisca ? corAlerta : Color.black;

                // Controla a luz pontual se estiver configurada
                if (luzLED != null)
                    luzLED.enabled = visivelPisca;
            }
        }
    }

    // ─────────────────────────────────────────────────────────
    // MÉTODO PÚBLICO — chamado pelo evento OnSelect do XR
    // Adicione este método no campo "On Select ()" do componente
    // XR Simple Interactable no Inspector
    // ─────────────────────────────────────────────────────────
    public void AlternarEstado()
    {
        emAlerta = !emAlerta;   // Inverte o estado

        if (emAlerta)
        {
            Debug.Log("[H2VSENSE] ⚠️ ALERTA ATIVADO — Vazamento detectado!");
            AplicarCorAlerta();
        }
        else
        {
            Debug.Log("[H2VSENSE] ✅ Sistema normalizado.");
            AplicarCorNormal();
        }
    }

    // ─────────────────────────────────────────────────────────
    // Aplica estado NORMAL (verde contínuo)
    // ─────────────────────────────────────────────────────────
    private void AplicarCorNormal()
    {
        tempoPisca   = 0f;
        visivelPisca = true;
        mat.color    = corNormal;

        if (luzLED != null)
        {
            luzLED.color   = corNormal;
            luzLED.enabled = true;
        }
    }

    // ─────────────────────────────────────────────────────────
    // Aplica estado ALERTA (vermelho piscando)
    // ─────────────────────────────────────────────────────────
    private void AplicarCorAlerta()
    {
        mat.color = corAlerta;

        if (luzLED != null)
            luzLED.color = corAlerta;
    }

    // ─────────────────────────────────────────────────────────
    // Detecta clique do mouse no Editor (para testes sem VR)
    // ─────────────────────────────────────────────────────────
    private void OnMouseDown()
    {
        AlternarEstado();
    }
}
