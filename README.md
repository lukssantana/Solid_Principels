SOLID

S => SRP => Single Responsibility Principle

O => OCP => Open / Closed Principle

L => LSP => Liskov Substitution Principle

I => ISP => Interface Segregation Principle

D => DIP => Dependency Inversion Principle

Este projeto tem como intenção demonstrar a violação de cada um dos princípios bem como utilizar os mesmos para a solução e demonstrar como o SOLID pode lhe proporcionar um melhor design de código facilitando a manutenção e o teste.
-------------------------------------------------------------------------------------------------
PROJETO.:

1 - SRP.: "Uma classe deve ter um, e somente um, motivo para mudar".

No exemplo, temos.:

    Violação -> O metodo AdicionarCliente da classe cliente, está com mais responsabilidades do que deveria, como validar, persistir, enviarEmail, violando assim o principio de SRP, como
    falta de coesão, alto acoplamento, dificuldades de implementar testes automatizados....... 

    Solução -> Para evitar a "GodClass", foi separada as responsabilidades conforme a funcionalidade de cada service, e centralizada em uma única responsabilidade em ClienteService.cs, assim respeitando o principio de SRP. 

2 - OCP.: "Obj ou entidades devem estar abertos para extensão, mas fechados para modificação".

No exemplo, temos.:

    Violação -> A classe debitoConta precisa verificar o tipoConta para aplicar a regra, porém se a mesma tiver alteração incluindo um novo tipo, a mesma deverá ser modificada, quebrando assim o principio de OCP. Alterar uma classe já existente para adicionar um novo comportamento, corremos um sério risco de introduzir bugs em algo que já estava funcionando.

    Solução -> Para evitar, devemos criar uma classe abstrata/interface para permitir extensão da mesma, sendo assim concentro a funcionalidades em DebitoConta e extendo para as demais, respeitando assim o principio de OCP. 

