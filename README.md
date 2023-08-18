# Sistema de Emissão de Bilhetes com RabbitMQ

Este projeto é um exemplo simples de como integrar aplicativos usando o RabbitMQ para troca de mensagens assíncronas. Consiste em um aplicativo de console e uma API que trabalham juntos para processar reservas de bilhetes.

## Objetivo

Este projeto foi criado como parte de um estudo sobre RabbitMQ, mostrando como os aplicativos podem se comunicar de forma assíncrona. Ele oferece uma visão básica da troca de mensagens entre componentes de um sistema distribuído.

## Funcionalidades Principais

- O aplicativo de console consome detalhes de reservas de bilhetes da fila "bookings" no RabbitMQ e os exibe.
- A API aceita solicitações para criar reservas de bilhetes, armazenando temporariamente os detalhes em memória e enviando-os como mensagens para a fila "bookings" no RabbitMQ.
