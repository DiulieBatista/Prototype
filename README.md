#  PROTOTYPE
 
* **Serviço Nacional de Aprendizagem Industrial (SENAI)**
*  **Instrutor :Frederico Martins Aguiar**
* **Aluno : Diulie Mileide Batista Correia**
  
  --------------------------------------------------------
  
#  Introdução
  
O padrão Prototype delega o processo de clonagem para o próprio objeto que está sendo clonado. O padrão declara um interface comum para todos os objetos que suportam clonagem.
Essa interface permite que você clone um objeto sem acoplar seu código à classe daquele objeto. Geralmente, tal interface contém apenas um único método clonar .A implementação do método clonar é muito parecida em
todas as classes. O método cria um objeto da classe atual e carrega todos os valores de campo para do antigo objeto para o novo. Você pode até mesmo copiar campos privados porque a maioria das linguagens de programação permite objetos
acessar campos privados de outros objetos que pertençam a mesma classe.Um objeto que suporta clonagem é chamado de um protótipo. Quando seus objetos têm dúzias de campos e centenas de possíveis configurações, clonálos pode servir como uma alternativa à subclasses.



 <div align="center">
<img src="Imagens/WhatsApp Image 2026-03-24 at 20.44.57 (1).jpeg" alt="Descrição" width="800"/>
</div>

  ---------------------------------------------

#  Problema que resolve

Em muitos sistemas, a criação de objetos pode envolver múltiplas configurações, inicializações complexas ou dependências entre componentes, tornando esse processo demorado e difícil de manter. Quando o sistema precisa gerar várias instâncias com características semelhantes, recriar cada objeto manualmente pode resultar em duplicação de código, maior consumo de recursos e aumento da complexidade estrutural da aplicação.

O padrão Prototype surge como uma solução para esse cenário, permitindo que novos objetos sejam criados a partir da clonagem de uma instância previamente configurada. Dessa forma, o sistema evita a repetição de processos de inicialização, tornando a criação de novas instâncias mais rápida, eficiente e consistente, além de contribuir para um código mais organizado e de fácil manutenção.

 <div align="center">
<img src="Imagens/WhatsApp Image 2026-03-25 at 13.10.53.jpeg" alt="Descrição" width="800"/>
</div>



-------------------------------------------------------------------------------------
#  Estrutura

A estrutura do Prototype é composta por três elementos principais que trabalham juntos para permitir a criação de novos objetos por meio da clonagem de instâncias existentes.

### Prototype
É a interface ou classe abstrata responsável por declarar o método de clonagem, geralmente chamado Clone(). Esse método define o contrato que permitirá copiar um objeto existente.

### Concrete Prototype
São as classes concretas que implementam a interface Prototype. Elas definem como o processo de clonagem será realizado, retornando uma nova instância baseada nas características do objeto original.

### Client
É o componente responsável por solicitar a criação de novos objetos. Em vez de instanciar diretamente uma classe, o cliente utiliza o método de clonagem do protótipo para gerar novas instâncias.

Essa estrutura permite que o cliente crie novos objetos sem depender diretamente das classes concretas, promovendo maior flexibilidade, reutilização de código e redução do acoplamento no sistema.



 <div align="center">
<img src="Imagens/WhatsApp Image 2026-03-25 at 13.25.36.jpeg" alt="Descrição" width="800"/>
</div>


-----------------------------

#  Participantes

Os principais participantes do padrão Prototype são responsáveis por definir e executar o processo de clonagem dos objetos dentro do sistema.

### Prototype
É a interface ou classe abstrata que define o método de clonagem, geralmente chamado Clone(). Esse método estabelece o contrato que permite que os objetos possam ser copiados.

### ConcretePrototype
São as classes concretas que implementam a interface Prototype. Elas definem a lógica de clonagem, especificando como os atributos do objeto original serão copiados para criar uma nova instância.

### Client
É o componente que utiliza o protótipo para criar novos objetos. Em vez de instanciar diretamente uma classe, o cliente solicita a clonagem de um objeto existente, tornando o processo de criação mais simples e flexível.

-------------------------------------------------------

# Justificativa da escolha

Escolhi o padrão Prototype porque ele mostra de forma clara como podemos reutilizar um objeto já existente para criar novas instâncias de maneira mais simples e eficiente. Para facilitar o entendimento, usei a analogia da multiplicação celular: assim como uma célula se divide para gerar outras células semelhantes, no Prototype um objeto pode ser ‘clonado’ para criar novos objetos a partir de um modelo base.

<div align="center">
<img src="Imagens/WhatsApp Image 2026-03-24 at 21.11.21.jpeg" alt="Descrição" width="800"/>
</div>


------------------------------

# Explicação da implementação no projeto

No projeto desenvolvido em C# utilizando Windows Presentation Foundation, o padrão Prototype foi implementado por meio de uma classe base responsável por definir o método de clonagem dos objetos.

Essa classe contém um método que permite criar uma cópia do próprio objeto, replicando suas propriedades e configurações. Dessa forma, sempre que o sistema precisa gerar uma nova instância, ele utiliza a clonagem do objeto protótipo já existente, evitando a necessidade de recriar manualmente todas as suas características.

Essa abordagem torna o processo de criação de novos objetos mais rápido e eficiente, além de contribuir para a redução de código repetitivo e para uma melhor organização da estrutura do sistema.


-----------------------------

# Análise crítica

O Prototype é especialmente eficiente em cenários onde o sistema precisa criar várias instâncias com características semelhantes, pois evita a repetição de processos de inicialização complexos e reduz a duplicação de código. Dessa forma, a criação de novos objetos torna-se mais rápida e organizada.

Por outro lado, quando os objetos possuem estruturas internas mais complexas ou referências para outros objetos, a implementação da clonagem pode exigir cuidados adicionais, como o uso de cópia profunda (deep copy), garantindo que todos os elementos internos sejam realmente duplicados e não apenas referenciados pela nova instância.



 <div align="center">
<img src="Imagens/WhatsApp Image 2026-03-25 at 13.14.22.jpeg" alt="Descrição" width="800"/>
</div>

----------------------------------------------------------
# Comparação com abordagens sem o padrão

Sem a utilização do padrão Prototype, cada objeto precisaria ser criado manualmente por meio de construtores e da configuração completa de seus atributos. Esse processo pode tornar o código mais repetitivo, aumentar o tempo de desenvolvimento e dificultar a manutenção do sistema.

Com o uso do Prototype, é possível criar novos objetos a partir da clonagem de um modelo já existente. Dessa forma, o sistema reutiliza uma instância previamente configurada, tornando a criação de novos objetos mais rápida, organizada e eficiente.

---------------------------------------------------
# Vantagens

* **Criação rápida de objetos** , pois novas instâncias podem ser geradas por clonagem em vez de serem construídas do zero.
* **Reutilização de estruturas já existentes**, permitindo aproveitar configurações previamente definidas.
* **Redução de código duplicado**, evitando repetir processos de inicialização em diferentes partes do sistema.
* **Maior flexibilidade na criação de objetos**, facilitando a geração de diferentes variações a partir de um mesmo modelo base.
* **Melhor desempenho em cenários com muitas instâncias**, já que a clonagem costuma ser mais eficiente do que a criação completa de novos objetos.


------------------------------------------------------------------
#  Desvantagens

* **Maior dificuldade na implementação** quando os objetos possuem estruturas internas complexas.
* **Necessidade de clonagem profunda (deep copy)** em alguns casos, para garantir que todas as referências internas sejam realmente duplicadas.
* **Aumento da complexidade na manutenção**, já que a lógica de clonagem precisa ser cuidadosamente implementada e gerenciada.

--------------------------------
#  Exemplos reais de uso no mercado

* **Jogos digitais**
O padrão Prototype é utilizado para criar múltiplos personagens, inimigos ou objetos do cenário a partir de um modelo base, permitindo gerar diversas instâncias semelhantes de forma rápida e eficiente.

* **Sistemas gráficos**
Softwares de design utilizam a clonagem de elementos visuais para duplicar objetos como formas, imagens ou componentes gráficos, mantendo suas propriedades e configurações.

* **Templates de documentos**
Aplicações de edição de documentos permitem criar novos arquivos a partir de modelos previamente configurados, reutilizando estrutura, formatação e configurações padrão.

* **Frameworks de interface**
Componentes de interface podem ser duplicados mantendo suas configurações originais, facilitando a reutilização de elementos visuais dentro da aplicação.

----------------------
# Referencias 

Design Patterns: Elements of Reusable Object-Oriented Software.
GAMMA, Erich; HELM, Richard; JOHNSON, Ralph; VLISSIDES, John.
Boston: Addison-Wesley, 1994.

Head First Design Patterns.
FREEMAN, Eric; FREEMAN, Elisabeth.
Sebastopol: O'Reilly Media, 2004.

Microsoft .NET.
Documentação oficial da plataforma .NET e boas práticas de desenvolvimento.
Disponível em: https://learn.microsoft.com

Windows Presentation Foundation.
Documentação oficial do framework para criação de interfaces gráficas.
Disponível em: https://learn.microsoft.com/dotnet/desktop/wpf/

GeeksforGeeks.
Prototype Design Pattern – System Design.
Disponível em: https://www.geeksforgeeks.org/prototype-design-pattern/

DigitalOcean.
Gang of Four (GoF) Design Patterns.
Disponível em: https://www.digitalocean.com/community/tutorials/gangs-of-four-gof-design-patterns

------------



  
  
  
