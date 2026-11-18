## 🚗 GP CAR - Sistema de Gerenciamento e Locação de Veículos

<p align="center">
  <img src="app.png" alt="Logo GP CAR" width="120" />
</p>

<p align="center">
  <img src="https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" alt=".NET 10" />
  <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white" alt="C#" />
  <img src="https://img.shields.io/badge/Windows_Forms-0078D7?style=for-the-badge&logo=windows&logoColor=white" alt="Windows Forms" />
  <img src="https://img.shields.io/badge/MySQL-4479A1?style=for-the-badge&logo=mysql&logoColor=white" alt="MySQL" />
  <img src="https://img.shields.io/badge/Architecture-3--Tier-orange?style=for-the-badge" alt="3 Camadas" />
</p>

---

### 📌 Sobre o Projeto
O **GP CAR** é um sistema desktop desenvolvido para gerenciamento e controle operacional de locadoras de veículos. A solução centraliza o controle de frotas e clientes, monitorando em tempo real o **status operacional de cada veículo** (*Disponível*, *Alugado* ou *Em Manutenção*), prevenindo locações indevidas de unidades indisponíveis.

Projeto desenvolvido com foco em boas práticas de engenharia de software, adotando a **Arquitetura em 3 Camadas** e banco de dados relacional **MySQL**.

---

### 📸 Telas da Aplicação
<img width="1919" height="1007" alt="Captura de tela 2026-11-18 192857" src="https://github.com/user-attachments/assets/4527efdc-2436-4511-a969-98a54db4ff8c" />





---

### 🏗️ Arquitetura em 3 Camadas

O sistema foi estruturado visando desacoplamento, facilidade de manutenção e segurança:

1. **Camada de Apresentação (UI / Views):**
   - Interface desktop moderna baseada no padrão MDI/Dashboard com menu lateral retrátil e painel central de conteúdo.
   - Destaque visual por cores no grid para identificação imediata do status:
     - 🟢 **Verde:** Veículo disponível para locação.
     - 🔴 **Vermelho:** Veículo alugado.
     - 🟡 **Amarelo:** Veículo em manutenção técnica.
   - Filtros dinâmicos e busca em tempo real por placa, marca e modelo.

2. **Camada de Aplicação / Negócio (Business):**
   - Centraliza todas as validações de integridade e regras de negócio.
   - Verificação de duplicidade de placas e CNHs.
   - Travamento de operações inválidas (ex: impedir envio de carro alugado diretamente para manutenção sem devolução).

3. **Camada de Acesso a Dados (Data):**
   - Comunicação com MySQL via driver otimizado `MySqlConnector`.
   - Repositórios com comandos SQL 100% parametrizados, prevenindo ataques de **SQL Injection**.

---

### 🗄️ Modelo Conceitual do Banco de Dados

Baseado em modelagem relacional feita no **brModelo**:

```text
+--------------+          +--------------+          +--------------+
|   CLIENTE    |  (1,n)   |   ALUGUEL    |   (1,1)  |   VEÍCULO    |
|--------------| <------> |--------------| <------> |--------------|
| id_cliente   |          | id_aluguel   |          | id_veiculo   |
| nome         |          | data_inicio  |          | placa (UQ)   |
| cnh (UQ)     |          | data_devol   |          | modelo/marca |
| telefone     |          | valor_total  |          | status       |
+--------------+          +-------+------+          +--------------+
                                  | (0,n)
                                  v
                          +--------------+
                          |   VISTORIA   |
                          |--------------|
                          | id_vistoria  |
                          | km_atual     |
                          | danos_obs    |
                          +--------------+
```

---

### 🚀 Funcionalidades

- [x] **Gestão de Frota:** Cadastro completo, edição e exclusão segura de veículos.
- [x] **Monitoramento de Status:** Atualização ágil de disponibilidade com feedback em cores.
- [x] **Cadastro de Clientes:** Controle com máscara de dados e validação de CNH única.
- [x] **Filtros e Buscas Rápidas:** Localização instantânea de veículos e clientes por múltiplos critérios.
- [x] **Diagnóstico de Conexão:** Teste integrado de conectividade com o banco MySQL diretamente pela interface.

---

### 🛠️ Como Executar o Projeto

#### Pré-requisitos:
- [.NET SDK 10](https://dotnet.microsoft.com/download) ou Visual Studio 2022+ com suporte a Windows Forms.
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) ativo na porta `3306`.

#### Passos:
1. Clone o repositório:
   ```bash
   git clone https://github.com/JoaquimSm/ProjetosFaculdade.git
   ```
2. Importe o banco de dados:
   - Abra o MySQL Workbench e execute o script `database.sql` incluído na raiz.
3. Configure as credenciais no arquivo `Data/Conexao.cs` (se a sua senha local não for a padrão `1234`):
   ```csharp
   private static string _connectionString = "Server=localhost;Port=3306;Database=gp_car_db;Uid=root;Pwd=SUA_SENHA;";
   ```
4. Compile e execute:
   ```bash
   dotnet run --project WinFormsApp1/GP_car.csproj
   ```
   *(Ou abra a solução no Visual Studio e pressione `F5`).*

---

### 👨‍💻 Desenvolvedor
- **Joaquim Morais** - [GitHub](https://github.com/JoaquimSm)

---
⭐ *Se este projeto te ajudou ou achou interessante, deixe uma estrela no repositório!*
