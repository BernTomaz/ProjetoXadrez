# ♟️ ProjetoXadrez

Aplicação de console em **C#** que implementa um jogo de **xadrez completo**.  
O projeto foi desenvolvido como prática de **Programação Orientada a Objetos (POO)**, aplicando conceitos de encapsulamento, herança, polimorfismo, tratamento de exceções e camadas de domínio.

---

## 🚀 Tecnologias Utilizadas

- **C#**  
- **.NET 6+**  
- **Programação Orientada a Objetos (POO)**  
- **Console Application**  

---

## 📌 Funcionalidades

- Implementação de todas as regras do **xadrez tradicional**  
- Validação de movimentos das peças  
- Lógica para xeque e xeque-mate  
- Controle de turnos e alternância entre jogadores  
- Tratamento de exceções para jogadas inválidas  
- Tabuleiro renderizado diretamente no console  

---

## 📂 Estrutura do Projeto

```
ProjetoXadrez/
│-- Board/            # Classes relacionadas ao tabuleiro e às posições
│-- Chess/            # Classes específicas do jogo de xadrez (peças, movimentos, partida)
│-- Program.cs        # Ponto de entrada da aplicação
```

---

## ⚙️ Como Executar o Projeto

### 🔹 Pré-requisitos
- [.NET SDK 6+](https://dotnet.microsoft.com/en-us/download)
- Editor de código como [Visual Studio](https://visualstudio.microsoft.com/) ou [VS Code](https://code.visualstudio.com/)

### 🔹 Passo a passo

1. Clone o repositório:
   ```bash
   git clone https://github.com/BernTomaz/ProjetoXadrez.git
   cd ProjetoXadrez
   ```

2. Compile e rode a aplicação:
   ```bash
   dotnet run
   ```

3. O tabuleiro e os movimentos serão exibidos no **console**.

---

## 📊 Modelo Conceitual

- **Board**: representa o tabuleiro e as posições  
- **Piece**: classe base para todas as peças de xadrez  
- **ChessPiece** (ex: King, Queen, Bishop, Knight, Rook, Pawn): herdam de Piece e implementam movimentos específicos  
- **ChessMatch**: gerencia a lógica da partida, incluindo turnos, xeque e xeque-mate  

---

## 🕹️ Como Jogar (Resumo)

- **Formato das jogadas:** sempre `coluna(l a h) + linha(1–8)` (ex.: `e2`, `e4`).
- **Fluxo:** informe a origem → informe o destino.
- **Turnos:** alternância automática entre brancas e pretas.

### Regras suportadas
- Movimentos legais de todas as peças.
- Xeque, xeque-mate e empate por afogamento.
- **Roque:** mova o rei para `g1/c1/g8/c8`; torre ajustada se válido.
- **En passant:** funciona automaticamente quando aplicável.
- **Promoção:** ao chegar na última fileira, digite `Q`, `R`, `B` ou `N`.

### Mensagens comuns
- Origem inválida → casa vazia, peça do rival ou sem movimentos.
- Destino inválido → movimento não permitido.
- Movimento deixa o rei em xeque → jogada rejeitada.

👉 Sempre usar letras minúsculas nas casas (`a2`, `h7`).

---
## 🧑‍💻 Autor

**Bernardo Tomaz**  
📌 [GitHub](https://github.com/BernTomaz)
