# 🌐 H2V_Metalab_VR

### Laboratório VR Interativo de Hidrogênio Verde

| | |
|---|---|
| 👨‍💻 **Autor** | Ednardo Pinheiro Peixoto |
| 🎓 **Residência** | Web 3.0 – Residência em TIC 29 |
| 🏫 **Instituição** | IREDE / SOFTEX / MCTI |
| 📅 **Data** | Maio de 2026 |
| 🔗 **Repositório** | https://github.com/EDNARDOPPEIXOTO99/H2V_Metalab_VR |

---

## 🚀 Apresentando o Projeto

O **H2V_Metalab_VR** é um ambiente de Realidade Virtual desenvolvido em **Unity 6.3 LTS** (6000.3.13f1), inspirado no projeto **H2VSENSE** da Peixoto Energy — sistema IoT de detecção inteligente de vazamento de hidrogênio verde.

O laboratório simula um **galpão industrial** com paredes de textura de tijolo, skybox de céu aberto, modelos 3D importados (cadeira e laptop) e **5 interações funcionais** via **ISDK_HandGrabInteraction** do Meta XR SDK, testadas com **Meta XR Simulator** (Quest 3 simulado).

---

## 🎯 Contexto e Objetivos no Metaverso

O **H2V_Metalab_VR** representa um ambiente industrial de monitoramento de H₂ verde no **Metaverso**, com quatro objetivos:

- **Treinamento técnico industrial** — simular procedimentos de segurança em plantas de H₂ sem risco físico real
- **Educação imersiva** — demonstrar o sistema H2VSENSE de forma interativa para estudantes e técnicos
- **Comunicação técnica** — apresentar o projeto a parceiros e investidores no metaverso como demonstração viva
- **Prototipagem digital** — gêmea digital simplificada da planta H₂ da Peixoto Energy

---

## 🛠️ Tecnologias

| Tecnologia | Versão / Detalhes |
|---|---|
| **Unity** | 6.3 LTS (6000.3.13f1) |
| **Meta XR All-in-One SDK** | Package Manager |
| **[BuildingBlock] Camera Rig** | Câmera VR oficial Meta |
| **Meta XR Simulator** | Quest 3 virtual (sem hardware) |
| **XR Plugin Management** | Oculus (Android) + OpenXR (PC) |
| **Build Target** | Android — Meta Quest (API 32/34) |
| **Render Pipeline** | URP |

---

## ⚙️ Configuração Técnica

```
Unity 6.3 LTS (6000.3.13f1)
Meta XR All-in-One SDK      → Package Manager
[BuildingBlock] Camera Rig  → câmera VR Meta XR SDK
XR Simulator (Quest 3)      → testes sem hardware físico
Build Platform              → Android / Meta Quest
API Level                   → Min 32 · Target 34 · ASTC
Project Setup Tool          → 0 erros críticos · 97+ itens ✓
```

---

## 🎮 Hierarquia da Cena

```
H2V_Metalab_VR
├── [BuildingBlock] Camera Rig
├── XR Interaction Manager
├── CENARIO
│   └── GALPAO
│       ├── Piso_Principal
│       ├── Paredes (Fundo, Frente_L, Frente_R, Esquerda, Direita)
│       └── Porta_Entrada
├── LAB_OBJETOS
│   ├── Tanque_H2          ← ISDK_HandGrabInteraction ✅
│   ├── Sensor_MQ8         ← ISDK_HandGrabInteraction ✅
│   ├── Painel_Info        ← ISDK_HandGrabInteraction ✅
│   ├── Alerta_Led         ← ISDK_HandGrabInteraction ✅
│   ├── Mesa_Controle
│   ├── Mesa Central
│   ├── Cadeira_Controle
│   └── Laptop
│       ├── Frame
│       └── Screen         ← ISDK_HandGrabInteraction ✅
├── XR_SYSTEM
│   └── XR Origin (VR)
└── LIGHTING
    └── Directional Light
```

---

## 🖐️ Interações (ISDK_HandGrabInteraction)

| # | Objeto | Interação | Contexto |
|---|---|---|---|
| 1 | **Sensor_MQ8** | Grab → inspeção do sensor portátil | Operador inspeciona sensor de H₂ |
| 2 | **Alerta_Led** | Grab → verificação do indicador | Reset de alerta de vazamento |
| 3 | **Laptop/Screen** | Grab → acesso ao dashboard | Interface H2VSENSE |
| 4 | **Painel_Info** | Grab → painel de status | Dados de concentração e temperatura |
| 5 | **Tanque_H2** | Grab → inspeção do tanque | Procedimento de vistoria industrial |

> **Atividade Básica** utiliza interações 1, 2 e 3.
> **Atividade Avançada** utiliza todas as 5 interações.

---

## ▶️ Como Executar

1. Abrir **Unity Hub** → **Open** → pasta `H2V_Metalab_VR/`
2. Abrir cena: `Assets/Scenes/SampleScene.unity`
3. Pressionar **Play (▶)**

### Controles no PC (Editor)

| Ação | Controle |
|---|---|
| Mover câmera | Botão direito + **W A S D** |
| Subir / Descer | Botão direito + **E / Q** |
| Zoom | Scroll do mouse |
| Focar objeto | Selecionar + **F** |

> ⚠️ Testado no Unity Editor com Meta XR Simulator (Quest 3). Sem necessidade de hardware VR físico.

---

## 🏗️ Processo de Criação e Dificuldades

### Desenvolvimento

**Fase 1 — Configuração:** Maior desafio foi a instalação do Meta XR SDK no Unity 6.3 LTS (sem suporte oficial). Solução: Meta XR All-in-One SDK mais recente + 97 correções manuais via Project Setup Tool.

**Fase 2 — Ambiente:** Galpão construído com primitivos Unity + texturas URP customizadas. Modelos 3D (cadeira, laptop) importados da Asset Store. Hierarquia planejada previamente para manter organização.

**Fase 3 — Interações:** 5 interações ISDK_HandGrabInteraction implementadas e testadas uma a uma. Cada objeto interagível precisou de Rigidbody (Is Kinematic=true) para funcionar corretamente.

### Desafios Resolvidos

- **Compatibilidade SDK/Unity 6:** Não há suporte oficial — resolvido com Project Setup Tool (0 erros críticos)
- **Testes sem Quest físico:** Uso do Meta XR Simulator para simular Quest 3 e controles Touch
- **Erro NaN no Sensor_MQ8:** ISDK exigia Rigidbody no objeto — adicionado com Is Kinematic=true
- **Materiais URP:** Materiais Legacy incompatíveis — convertidos via Edit > Rendering > Convert Materials

---

## 📄 Documentação

| Arquivo | Descrição |
|---|---|
| `Relatorio_Tecnico_Basico.docx` | Relatório — Atividade Básica (3 interações) |
| `Relatorio_Tecnico_Avancado.docx` | Relatório — Atividade Avançada (5 interações) |
| `link_repositorio.txt` | Link do repositório para entrega no Homero |
| `README.md` | Este arquivo |

---

## 🚀 Melhorias Futuras

- [ ] Build APK para Meta Quest 2/3
- [ ] Dados IoT reais do H2VSENSE via MQTT em tempo real
- [ ] Dashboard TextMeshPro 3D no Painel_Info
- [ ] Animações e AudioSource no Alerta_Led
- [ ] Multiplayer com Photon PUN2

---

## 📚 Contexto Acadêmico

> **Atividade Básica:** Projeto Final — Meu Primeiro Ambiente VR
> **Atividade Avançada:** Unidade 1, Capítulo 3 — Fundamentos do Metaverso
> Trilha Metaverso — Web 3.0 | Residência em TIC 29 | Prof.ª Ana Beatriz

---

*Uso acadêmico — Residência em TIC 29 / IREDE / SOFTEX / MCTI*