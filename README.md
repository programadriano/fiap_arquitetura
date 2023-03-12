# Projeto C# com .NET 6 e arquitetura hexagonal
Este é um projeto básico em C# com .NET 6 que segue a arquitetura hexagonal. A arquitetura hexagonal é um estilo de arquitetura de software que ajuda a separar as preocupações do negócio das preocupações técnicas. O objetivo é tornar o software mais flexível e adaptável às mudanças no negócio, reduzindo o acoplamento entre os componentes.

# Configuração do projeto
O projeto está configurado com o .NET 6 e segue as seguintes convenções:

A solução contém os projetos "Core", "Infra" e "Application".
O projeto "Core" contém a lógica de negócios e as interfaces que serão implementadas no projeto "Infra" que esta dentro da pasta "Adapter/driven".
O projeto "Infra" contém as implementações das interfaces definidas no projeto "Core".
O projeto "Application" contém a camada de aplicação que usa os serviços definidos no projeto "Core" através de "Use Cases".

# Como executar o projeto
Para executar o projeto, basta clonar o repositório e abrir a solução no Visual Studio 2022. Em seguida, selecione o projeto "API" que esta dentro da pasta "Adapter/driver" como o projeto de inicialização e execute-o.


# Licença
Este projeto está sob a licença MIT. Você é livre para usá-lo, modificá-lo e distribuí-lo como quiser, desde que mantenha a licença original e os direitos autorais. Veja o arquivo LICENSE para mais detalhes.