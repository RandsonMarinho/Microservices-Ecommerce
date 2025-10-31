🛒 E-commerce Microservices
📘 Descrição

Este projeto é uma aplicação de e-commerce desenvolvida em .NET 8 com arquitetura de microserviços.
O objetivo é demonstrar como dividir uma aplicação em serviços independentes que se comunicam via RabbitMQ e são orquestrados através de um API Gateway.

🧩 Estrutura dos Serviços

O sistema é composto por 3 projetos principais:

Serviço	Porta padrão	Função
ApiGateway	5237	Roteia as requisições para os microserviços corretos
InventoryService	5018	Gerencia o estoque de produtos
OrderService	5020 (por exemplo)	Gerencia pedidos e integração com o estoque
⚙️ Tecnologias Utilizadas

.NET 8 / ASP.NET Core Web API

Ocelot (API Gateway)

RabbitMQ (mensageria)

Docker (containerização)

Entity Framework Core (em memória ou SQL Server)

C#

🚀 Como Executar o Projeto
🐋 1. Subir o RabbitMQ com Docker
docker run -d --hostname rabbitmq --name rabbitmq -p 5672:5672 -p 15672:15672 rabbitmq:3-management


Acesse o painel do RabbitMQ:
👉 http://localhost:15672

Usuário: guest
Senha: guest

▶️ 2. Executar os Microserviços

Você pode rodar todos de uma vez pelo Visual Studio:

Selecione “Multiple Startup Projects” e marque ApiGateway, InventoryService e OrderService.

Ou manualmente via terminal:

cd src/InventoryService
dotnet run

cd ../OrderService
dotnet run

cd ../ApiGateway
dotnet run

🌐 3. Testar no Navegador

Listar produtos:
👉 http://localhost:5237/products

Listar pedidos:
👉 http://localhost:5237/orders

🧠 Conceitos Envolvidos

Comunicação assíncrona via mensageria (RabbitMQ)

Separação de responsabilidades entre serviços independentes

Escalabilidade e isolamento de falhas

Uso de API Gateway para simplificar o acesso externo

🧱 Estrutura de Pastas (exemplo)
ecommerce-microservices/
 ├── src/
 │   ├── ApiGateway/
 │   ├── InventoryService/
 │   ├── OrderService/
 ├── docker-compose.yml (opcional)
 └── README.md

💡 Próximos Passos

 Adicionar persistência real (SQL Server ou PostgreSQL)

 Criar autenticação JWT

 Criar microsserviço de pagamentos

 Adicionar testes unitários e de integração

👨‍💻 Autor
Randson Marinho
💼 [LinkedIn](https://www.linkedin.com/in/randson-marinho-6216b3289/)
