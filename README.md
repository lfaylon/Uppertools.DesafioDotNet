# Uppertools.DesafioDotNet

Vamos ver alguns dos benefícios da Arquitetura aqui:

  Injeção de Dependência : Usa e fornece uma infraestrutura DI convencional. 
  
  Repository : Cria um repositório padrão para cada entidade. O repositório padrão tem muitos métodos úteis. Podemos estender o repositório padrão para atender às 
  nossas necessidades. Os repositórios abstraem os DBMS e ORMs e simplificam a lógica de acesso aos dados.

  Autorização : Verifica as permissões declarativamente, mas também tem outras maneiras de autorizar.

  Validação : Verifica automaticamente se a entrada é nula. Ele também valida todas as propriedades de uma entrada com base em atributos de anotação de dados padrão e 
  regras de validação personalizadas. Se uma solicitação não for válida, ela lançará uma exceção de validação adequada e a tratará no lado do cliente.

  Log de auditoria : usuário, navegador, endereço IP, serviço de chamada, método, parâmetros, tempo de chamada, duração da execução e algumas outras 
  informações são salvas automaticamente para cada solicitação com base em convenções e configurações.

  Unidade de trabalho : Cada método de serviço de aplicativo é considerado uma unidade de trabalho por padrão. Ele cria automaticamente uma conexão e 
  inicia uma transação no início do método. Se o método for concluído com êxito sem exceção, a transação será confirmada e a conexão será descartada. 
  Mesmo que este método use repositórios ou métodos diferentes, todos eles serão atômicos (transacionais). Todas as alterações nas entidades são salvas automaticamente 
  quando uma transação é confirmada. 

  Manipulação de Exceções : Quase nunca temos que lidar manualmente com exceções nessa arquitetura em um aplicativo da web. Todas as exceções são tratadas 
  automaticamente por padrão! Se ocorrer uma exceção, serár egistrado automaticamente e retornará um resultado adequado ao cliente. Por exemplo, 
  se for uma solicitação AJAX, ele retornará um objeto JSON ao cliente indicando que ocorreu um erro. Ele oculta a exceção real do cliente, 
  a menos que a exceção seja uma UserFriendlyException. Ele também entende e trata os erros do lado do cliente e mostra as mensagens apropriadas aos usuários.

  Logging : Como você vê, podemos escrever logs usando o objeto Logger definido na classe base. Log4Net é usado por padrão, mas é mutável e configurável.

  Localização : Usamos o método 'L' ao lançar a exceção, dessa forma, ele é localizado automaticamente com base na cultura do usuário atual.

  Auto Mapping : Usamos a biblioteca AutoMapper para realizar o mapeamento. Podemos facilmente mapear propriedades de um objeto para outro com base em 
  convenções de nomenclatura.

  Camada de API dinâmica : Geralmente, temos que escrever um controlador de API wrapper para expor métodos a clientes JavaScript, mas isso acontece automaticamente em 
  tempo de execução. Dessa forma, podemos usar métodos de serviço de aplicativo diretamente dos clientes.

  Dynamic JavaScript AJAX Proxy : Criamos métodos de proxy que tornam a chamada de métodos de serviço de aplicativo tão simples quanto chamar métodos 
  JavaScript no cliente.

  Com essa arquitetura fornecemos uma forte infraestrutura e modelo de desenvolvimento para modularidade , multilocação , cache , trabalhos em segundo plano , 
  filtros de dados , gerenciamento de configuração , eventos de domínio , testes de unidade e integração e assim por diante... Você se concentra em seu 
  código de negócios e não se repita!
