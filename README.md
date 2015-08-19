# RCE
![build](https://travis-ci.org/tkpb/RCE.svg) ![estado](https://img.shields.io/badge/state-alpha-red.svg) ![licença](https://img.shields.io/badge/license-GPLv3-blue.svg)

###Resumo
Registrador Constante de Entrada. Registra constantemente a entrada de dados pelo teclado e mouse e salva em intervalos determinados de acordo com a configuração do usuário.

###Objetivo
O RCE tem como objetivo principal possibilitar o resgate de informações que foram digitadas mas foram perdidas por algum motivo, como por exemplo perda de energia repentina.

###Desempenho
A aplicação no geral é bem leve e dificilmente o usuário terá problemas de falta de recursos (como CPU e memória). Com o buffer padrão de 30 segundos o usuário já tem uma perda quase insignificante de dados em caso de falha da máquina. O usuário pode escolher menos tempo (consome menos memória e mas mais processador) ou mais tempo (consome menos processador e mais memória).
