# 🌐 H2V_Metalab_VR

### Ambiente VR Educacional de Hidrogênio Verde

| | |
|---|---|
| 👨‍💻 **Autor** | Ednardo Pinheiro Peixoto |
| 🎓 **Residência** | Web 3.0 – Residência em TIC 29 |
| 🏫 **Instituição** | IREDE / SOFTEX / MCTI |
| 📅 **Data** | Maio de 2026 |

---

## 📌 Descrição

O **H2V_Metalab_VR** é um ambiente de Realidade Virtual desenvolvido em **Unity 6.3 LTS**, inspirado no projeto **H2VSENSE** da Peixoto Energy — sistema IoT de detecção de vazamento de hidrogênio verde.

O laboratório virtual contém:

| Objeto | Descrição |
|---|---|
| 🔵 **Tanque H2** | Tanque de armazenamento de hidrogênio |
| 🟢 **Sensor_MQ8** | Sensor de detecção de gás H₂ |
| 🟣 **Painel_Info** | Interface informativa do sistema |
| 🟠 **Mesa_Controle** | Estação de monitoramento |
| 🔴 **Alerta_Led** | Indicador visual de alerta |

---

## 🛠️ Tecnologias Utilizadas

| Tecnologia | Versão / Detalhes |
|---|---|
| **Unity** | 6.3 LTS (6000.3.15f1) |
| **Meta XR All-in-One SDK** | Instalado via Package Manager |
| **XR Plugin Management** | Oculus (Android) + OpenXR (PC) |
| **Android Build Support** | API Min 32 · Target 34 · ASTC |
| **Render Pipeline** | URP (Universal Render Pipeline) |

---

## ▶️ Como Executar o Projeto

1. Abrir o **Unity Hub**
2. Clicar em **Open** → navegar até a pasta `H2V_Metalab_VR/`
3. Abrir a cena: `Assets/Scenes/H2V_Metalab_Scene.unity`
4. Pressionar **Play (▶)** no Unity Editor

### Controles de Navegação (PC/Notebook)

| Ação | Controle |
|---|---|
| Mover câmera | Botão direito + **W A S D** |
| Subir / Descer | Botão direito + **E** / **Q** |
| Rotacionar visão | **Alt** + botão esquerdo |
| Zoom | Scroll do mouse |
| Focar em objeto | Selecionar + tecla **F** |

---

## 🧱 Estrutura do Projeto

```
H2V_Metalab_VR/
├── Assets/
│   ├── Oculus/              ← Meta XR SDK assets
│   ├── Scenes/
│   │   └── H2V_Metalab_Scene.unity
│   ├── Settings/            ← URP e configurações
│   └── README.txt           ← Instruções básicas
├── Packages/                ← Meta XR SDK (manifest.json)
├── ProjectSettings/         ← Build Android, XR Plugin Management
├── README.md
├── .gitignore
├── link_repositorio.txt
└── Relatorio_Tecnico_H2V_Metalab_VR.docx
```

---

## 🎮 Hierarquia da Cena

```
SampleScene
├── Global Volume
├── XR Interaction Manager
├── [ENVIRONMENT]
│   └── Piso_Principal
├── [LAB_OBJETOS]
│   ├── Tanque H2
│   ├── Sensor_MQ8
│   ├── Painel_Info
│   ├── Alerta_Led
│   └── Mesa_Controle
├── [XR_SYSTEM]
│   └── XR Origin (VR)
│       └── Camera Offset
│           └── Main Camera
├── [LIGHTING]
│   └── Directional Light
└── UI
```

---

## ⚙️ Configuração Técnica

```
Unity 6.3 LTS (6000.3.15f1)
Meta XR All-in-One SDK      → instalado via Package Manager
XR Plugin Management        → Oculus (Android) + OpenXR (PC)
Build Platform              → Android
Minimum API Level           → Android 12 (API 32)
Target API Level            → Android 14 (API 34)
Texture Compression         → ASTC
Project Setup Tool          → 0 erros · 97+ itens verificados ✓
```

---

## 🚀 Melhorias Futuras

- [ ] Integração com Meta Quest 2/3 (build APK)
- [ ] Dados IoT reais do H2VSENSE via MQTT em tempo real
- [ ] Animações de alerta no `Alerta_Led`
- [ ] Dashboard de dados dentro do ambiente VR
- [ ] Multiplayer colaborativo com Photon PUN2

---

## 📚 Contexto Acadêmico

> Projeto desenvolvido como **Projeto Final — Meu Primeiro Ambiente VR**  
> Trilha de Metaverso – Web 3.0 | Residência em TIC 29
>
> ⚠️ Desenvolvido e testado no Unity Editor (PC), sem dispositivo VR físico,  
> conforme permitido pela proposta da atividade.

---

## 📎 Licença

Uso acadêmico e educacional.
