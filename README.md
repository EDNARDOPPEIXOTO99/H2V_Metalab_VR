🌐 H2V_Metalab_VR — Ambiente VR Educacional de Hidrogênio Verde
👨‍💻 Autor: Ednardo Pinheiro Peixoto
🎓 Residência: Web 3.0 – TIC 29
📅 Data: Maio de 2026
🏫 Instituição: IREDE / SOFTEX / MCTI

📌 Descrição
O H2V_Metalab_VR é um ambiente de Realidade Virtual desenvolvido em Unity 6.3 LTS,
inspirado no projeto H2VSENSE da Peixoto Energy — sistema IoT de detecção de vazamento de hidrogênio verde.
O laboratório virtual contém:

🔵 Tanque H2 — tanque de armazenamento de hidrogênio
🟢 Sensor_MQ8 — sensor de detecção de gás H₂
🟣 Painel_Info — interface informativa do sistema
🟠 Mesa_Controle — estação de monitoramento
🔴 Alerta_Led — indicador visual de alerta


🛠️ Tecnologias Utilizadas
TecnologiaVersão / DetalhesUnity6.3 LTS (6000.3.15f1)Meta XR All-in-One SDKInstalado via Package ManagerXR Plugin ManagementOculus (Android) + OpenXR (PC)Android Build SupportAPI Min 32 · Target 34 · ASTCRender PipelineURP (Universal Render Pipeline)

▶️ Como Executar o Projeto

Abrir o Unity Hub
Clicar em Open → navegar até a pasta H2V_Metalab_VR/
Abrir a cena: Assets/Scenes/H2V_Metalab_Scene.unity
Pressionar Play (▶) no Unity Editor

Controles de Navegação (PC/Notebook)
AçãoControleMover câmeraBotão direito + W A S DSubir / DescerBotão direito + E / QRotacionar visãoAlt + botão esquerdoZoomScroll do mouseFocar em objetoSelecionar + tecla F

🧱 Estrutura do Projeto
H2V_Metalab_VR/
├── Assets/
│   ├── Oculus/
│   ├── Scenes/          ← H2V_Metalab_Scene.unity
│   ├── Settings/
│   └── README.txt
├── Packages/            ← Meta XR SDK
├── ProjectSettings/     ← Build Android, XR Plugin Management
├── README.md
├── .gitignore
└── link_repositorio.txt

🎮 Hierarquia da Cena
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

🚀 Melhorias Futuras

Integração com Meta XR SDK para óculos VR (Meta Quest 2/3)
Integração IoT com sensores H2VSENSE em tempo real via MQTT
Animações de alerta no Alerta_Led
Dashboard de dados dentro do ambiente VR
Multiplayer colaborativo com Photon PUN2


📚 Contexto Acadêmico
Projeto desenvolvido como Projeto Final — Meu Primeiro Ambiente VR
Trilha de Metaverso – Web 3.0 | Residência em TIC 29

⚠️ Desenvolvido e testado no Unity Editor (PC), sem dispositivo VR físico,
conforme permitido pela proposta da atividade.


📎 Licença
Uso acadêmico e educacional.