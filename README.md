# 💎 Diamante de X

Este é um pequeno projeto em C# que gera um diamante composto pela letra `x`, com tamanho definido pelo usuário. O programa solicita que o usuário informe um número **ímpar e positivo**, e então desenha um diamante simétrico no console.

---

## 📋 Como funciona

O programa é dividido em duas partes principais:

- **Program.cs**: Responsável pela interação com o usuário (exibir cabeçalho, obter o valor de entrada e chamar o método de desenho).
- **GeradorDeDiamante.cs**: Contém a lógica para desenhar a parte superior, o meio e a parte inferior do diamante.

---

## 📌 Regras para o tamanho do diamante

- O número deve ser **ímpar**
- O número deve ser **positivo**

Se o usuário digitar um valor inválido, o programa solicitará novamente a entrada até receber um valor válido.

---

## 📦 Execução

### Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) instalado na máquina.

### Para executar:

```bash
dotnet run