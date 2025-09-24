# Sistema de Estacionamento (Console App)

Este é um projeto de console desenvolvido em C# .NET que simula o funcionamento básico de um sistema de estacionamento. O objetivo é permitir o gerenciamento de veículos, cálculo de valores a pagar e interação via linha de comando.

![C# Console Application](https://img.shields.io/badge/C%23-.NET-512BD4?style=for-the-badge&logo=csharp&logoColor=white)
![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)

## 🚀 Funcionalidades

O sistema oferece as seguintes funcionalidades principais:

* **Definição de Preços**: O usuário configura os valores de preço inicial e preço por hora do estacionamento no início da execução do programa.
* **Adicionar Veículo**: Permite registrar a placa de um veículo que está entrando no estacionamento.
* **Remover Veículo**: Remove um veículo do estacionamento e calcula o valor total a ser pago, com base no tempo de permanência e nos preços configurados.
* **Listar Veículos**: Exibe todos os veículos que estão atualmente estacionados.
* **Menu Interativo**: Navegação simples e intuitiva através de um menu de opções no console.

## 🛠️ Tecnologias Utilizadas

* **C#**: Linguagem de programação principal.
* **.NET 9**: Framework de desenvolvimento.
* **Console Application**: Tipo de aplicação.

## 📁 Estrutura do Projeto

O projeto está organizado da seguinte forma:

.
├── Estacionamento.sln
├── Estacionamento/
│   ├── bin/
│   ├── models/
│   │   └── EstacionamentoCarro.cs
│   ├── obj/
│   ├── Estacionamento.csproj
│   └── Program.cs
└── .gitignore

* `Estacionamento.sln`: Arquivo de solução do Visual Studio.
* `Estacionamento/`: Pasta principal do projeto.
    * `models/EstacionamentoCarro.cs`: Contém a classe `EstacionamentoCarro`, responsável pela lógica de negócio do estacionamento (adicionar/remover veículos, calcular preço).
    * `Program.cs`: Ponto de entrada da aplicação, onde o menu principal e a interação com o usuário são gerenciados.
* `.gitignore`: Define os arquivos e pastas que devem ser ignorados pelo controle de versão do Git.

## ⚙️ Como Rodar o Projeto

Siga os passos abaixo para clonar o repositório e executar a aplicação:

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/eduardoaiasi/DesafioEstacionamento.git
    cd DesafioEstacionamento/Estacionamento
    ```

2.  **Restaure as dependências (se necessário):**
    ```bash
    dotnet restore
    ```

3.  **Execute a aplicação:**
    ```bash
    dotnet run
    ```

## 🤝 Contribuição

Contribuições são sempre bem-vindas\! Se você tiver sugestões, melhorias ou encontrar algum bug, sinta-se à vontade para abrir uma *issue* ou enviar um *Pull Request*.

## 📄 Licença

Este projeto está licenciado sob a licença [MIT](https://opensource.org/licenses/MIT).

---