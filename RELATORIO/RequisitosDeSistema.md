# Spotmusic
## Requisitos do Sistema para a rede social para músicos


### Sumário
* Propósito do Documento
* Escopo do projeto
* Requisitos de Usuário
  * [RF01] Manter o cadastro do usuário
  * [RF02]  Autenticação
  * [RF03]  Fazer conexão com outros usuários
  * [RF04]  Publicação de fotos
  * [RF05]  Interação com outros usuários
* Requisitos do Sistema
  * [RF01]  Criar o perfil na rede social 
  * [RF02]  Criar grupos na rede social
  * [RF03]  Criação de Post no Feed de Notícias
  * [RF04]  Criar uma galeria de imagens
  * [RF05]  Curtir Posts de outros usuários
  * [RF06]  Cadastrar eventos 
  * [RF07]  Conversar com outros usuários
  * [RF08]  Sugestão de amizades
  * [RF09]  Denunciar publicações com irregularidades
  * [RF10]  Bloqueio de usuários que cometem ações irregulares
* Matriz de Rastreabilidade
* Apêndices
* Referências

### Spotmusic
### 1. Propósito do Documento
O objetivo deste documento é especificar as funcionalidades necessárias para o desenvolvimento da rede social para músicos. Definir as restrições sobre o uso de suas tecnologias e ferramentas.Também, fornecer os detalhes necessários para o desenvolvimento de funcionalidades e criação de diagramas. Assegurar que as funcionalidades aqui descritas farão parte do entregável ao final do projeto. Assegurar a passagem de conhecimento de maneira objetiva e descritiva sobre as necessidades do produto.

### 2. Escopo do projeto
Criar uma rede social para músicos. Com diversos músicos espalhados por diversos locais, eles acabam não se conhecendo e por consequência as vezes ficam com dificuldades para adicionar alguém em sua banda ou para procurar alguém interessado a participar de algum projeto. Com está rede social o principal objetivo será unir todos os músicos, fazendo conexão de todos por estilo musical, propósitos como montar banda ou criar algum *single* e o mais importante compartilhar momentos e experiências. A rede social Também propõe dar uma imersão muito superior para os amantes de música, podendo no futuro postar seus show para uma melhor divulgação, compartilhar músicas para que outros possam contribuir para a sua criação, grupos de instrumentos para compartilhar dicas e fotos e muito mais.

### 3. Requisitos de Usuário
- ####  [RF01]  Manter o cadastro do usuário
Ao músico deve ser possível cadastrar seus dados como idade, banda ao qual pertence, músicas que fez ou participou e demais informações relacionados a música.

- ####  [RF02] Cadastro de grupos
Ao músico deve ser possível de se cadastrar e criar diferentes grupos sejam de gêneros musicais, regiões ou da sua banda.

- ####  [RF03] Fazer conexão com outros usuarios
A rede social deve ser capaz de conectar os usuários seja incluindo no seu vínculo de amigos ou participando de grupos.

- ####  [RF04] Publicação de fotos
Ao músico deve ser possível publicar as suas fotos na sua galeria de imagens, perfil ou grupos.

- ####  [RF05] Interação com outros usuários
A rede social deve ter uma página de publicações onde o usuário possa interagir com as publicações de seus grupos e a outros músicos de que estejam ligados a seus ciclo de amizades.

- #### [RF06] Cadastrar eventos 
Ao músico deve ser possível registrar um evento com local, hora e dia para convidar outros músicos dessa rede social, o sistema deve ser capaz de avisar sobre o evento com antecedência.

- #### [RF07] Conversar com outros usuários
O sistema deve ser capaz de ter um meio de comunicação privada entre dois usuários onde possam trocar mensagens.

- #### [RF08] Sugestão de amizades
O sistema deve ser capaz de sugerir para o usuário amigos que talvez ele possa conhecer com base na quantidade de amigos em comum.

- #### [RF09] Denunciar publicações com irregularidades
O sistema deve ter a capacidade de por meio de denuncias, excluir uma publicação que contenha irregularidade.

- #### [RF10] bloqueio de usuários que cometem ações irregulares
Para o caso de algum usuário cometer algum ato criminoso ou suspeito, poderá ser bloqueado por quem não quiser mais ter vínculo.

### 4. Requisitos do Sistema

- #### RF01 
|Requisito  | Criar o perfil na rede Social |
|----------|----------------|
|Atores   | Usuário e Sistema.|
|Pré-condição   | Não pussuir um perfil na rede.|
|Fluxo básico | • O usuário acessa a interface para criar um perfil na rede social. <br>  •	O usuário deve informa seu nome. <br> •	O usuário deve informa seu e-mail. <br> •	O usuário deve informa uma senha. <br> •	O usuário deve informa sua data de nascimento. <br> •	O usuário deve informa seu endereço. <br> •	O usuário deve informar se esta em alguma banda. <br> • O usuário deve informar seu(s) instrumento(s) que utiliza. <br> • O usuário executa a criação do perfil e o sistema redireciona o usuário para a página principal. |
|Pós condição  |	Um perfil é criado com os dados informados pela pessoa e já passa a ser válido. |
|Fluxo alternativo  | •	A pessoa não informa um dos dados solicitados na interface de criação de perfil e então executa a criação do perfil, quando isso ocorrer, a mensagem “{nomeDoCampo} é obrigatório(a)” deve aparecer onde estiver faltando. <br> Por exemplo: “Nome é obrigatório(a)” ou “Data de nascimento é obrigatório(a)”  <br> •	A pessoa informa um e-mail não válido, deve aparecer o seguinte erro: "E-mail inválido! Tente novamente." <br>  •	A pessoa informa um e-mail que já está associado a algum perfil. Quando a pessoa executar a criação do perfil, a mensagem “Esse e-mail já está associado a um perfil” deve ser exibida. |
|Dados    |  •	Nome: Texto, máximo de 100 caracteres, não pode conter números. <br> •	Senha: Mais de 8 caracteres. <br> •	Data de nascimento: Data válida. Permite no mínimo 10 anos. <br> •	Endereço: Logradouro, número, complemento, bairro, cidade e estado. Todos os dados do tipo texto. <br> •	Nome da banda que participa e descrição da mesma: texto até no máximo 500 caracteres.  |
|Requisitos relacionados  | 	Nenhum |

- #### RF02 
|Requisito | Autenticação|
|--------|----------------|
|Atores   | Usuário, Sistema de email externo e sistema|
|Pré-condição   | Ter feito uma conta na rede social|
|Fluxo básico | • O usuário deve clicar em enviar codigo de autenticação pelo email. <br>  •	O usuário deve digitar o email usado no cadastro da conta. <br>  •	A rede social deve pedir para o usuário digitar o seu email em dois campos, para confirmar que o email estar correto. <br>  •	O usuário deve acessar seu email usado no cadastro para acessar o link de confirmação de cadastro. <br>  •	O usuário deve usar o código informado em seu email no campo de preenchimento do codigo na rede social. <br>  •	O usuário após confirmar seu cadastro no email, deve refazer o login na rede social.  |
|Pós condição  |	O usuário não validar sua conta. |
|Fluxo alternativo  | •	O usuário não aciona a função de enviar email para confirmação, a rede social irá limitar a conta para eitar uso indevido. <br>  •	O usuário tentar digitar o código de confirmação errado 3 vezes, ficará impedido de fazer uma nova tentativa nas próximas 24 horas. <br>  •	O usuário informa email diferente do usado no cadastro da conta, mensagem de erro aparecerá: "E-mail inválido! utilize o mesmo da coonta cadastrada." |
|Dados    |  •	Cógido: Texto, máximo de 8 caracteres, pode conter números e caracteres especiais. <br> • Email: texto, máximo 100 caracteres, deve conter o caractere "@" para ser definido como email.  |
|Requisitos relacionados  |  RF01  |

- #### RF03 
|Requisito | Criação de Post no Feed de Notícias|
|--------|----------------|
|Atores   | Usuários, redes externas e Sistema |
|Pré-condição   | Ter perfil na rede social e arquivo ou link compatível com a rede.|
|Fluxo básico | • O usuário acessa a página principal. <br>  •	O usuário informa que tipo de post deseja fazer. <br> Exemplos: <br>  1- apenas um texto. <br> 2- uma imagem. <br> 3- um link externo. <br>  • O usuário informa o tipo de privacidade do post, se será público ou apenas para amigos. <br>  • O usuário poderá marcar seus amigos nas postagens. <br> |
|Pós condição  |	O post criado poderá ser apagado ou alterado. |
|Fluxo alternativo  | • O usuário tentar criar um post sem nenhum tipo de dado ou informação, não poderá compartilhar. <br>  •O usuário tentar marcar pessoa que não esteja no seu vinculo de amizade, não irá aparecer como disponível para marcação. <br>  • o usuário anexar link ou arquivo incompatível, aparecerá a mensagem de erro: "Não compatível.". e será ignorado. |
|Dados    |  •	texto do post: Texto, máximo de 2000 caracteres. <br>  • Imagem: apenas nos formatos suportados, "jpg", "png" e "gif". Tamanho máximo de 2mb. <br>  • Link: Apenas de sites seguros e sem arquivo para download.  |
|Requisitos relacionados  |  RF01 e RF04  |

- #### RF04  
|Requisito | Criar uma galeria de imagens|
|--------|----------------|
|Atores   | Usuário, hardware do usuário e sistema|
|Pré-condição   | Ter perfil na rede social|
|Fluxo básico | • O usuário acessa o menu de imagens e pode escolher postar uma foto na sua galeria pessoal. <br>  • O usuário pode escolher as fotos armazenadas dentro do seu dispositivo. <br>  • o usuario pode informa na foto:<br> 1- titulo para a foto; <br> 2- Data da foto; <br> 3- local da foto; <br> 4- descrição para foto.<br> •	O usuário pode criar albuns para agrupar as fotos. <br> • O usuário poderá marcar seus amigos na imagem. <br>  • O usuário poderá usar alguma imagem da galeria para colocar como foto de perfil. |
|Pós condição  |	Imagem é postada na galeria e pode ser usada para ser compartilhada pelo usuário. |
|Fluxo alternativo  | • O usuário tentar postar a foto em dois albuns, será selecionado apenas o ultimo escolhido. <br>  • O usuário tentar marcar duas vezes a mesma pessoa na imagem, será ignorado. <br>  • O usuário informar mais de um lugar na imagem, será alterada para a nova localização. |
|Dados    |  •	Titulo da foto: Texto, máximo de 50 caracteres. <br>  • local da foto: Cidade, Estado e País. <br>  • Imagem: apenas nos formatos suportados, "jpg", "png" e "gif". Tamanho máximo de 2mb. <br> |
|Requisitos relacionados  |  RF01 E RF02  |

- #### RF05    
|Requisito | Curtir Posts de outros usuários |
|--------|----------------|
|Atores   | Usuários e Sistema|
|Pré-condição   | Ter perfil na rede social, ser amigo do outro usuário ou fazer parte do mesmo grupo.|
|Fluxo básico | • Uma pessoa acessa a página principal da rede social. <br> • O usuário navegando pelo feed de notícias, poderá curtir posts dos usuários que fazem parte do seu vinculo de amigos. <br> • O usuário dentro dos grupos poderá curtir os posts de outros usuários mesmo não sendo do seu vinculo de amigos. <br> • O post que tiver mais curtidas terá mais visualização. |
|Pós condição  |	O usuário poderá tirar seu curtir quando quiser. |
|Fluxo alternativo  | • O usuário curtir mais de uma vez a mesma postagem, o sistema reconhecerá como tirar o curtir. <br> • O usuário fazer muitas curtidas consecutivas, o sistema bloqueará o usuário por um tempo determinado. <br> • o usuário permanecer com o botão de curtir ativado por mais de 5 segundos, sistema irá ignorar curtida. |
|Dados    |  •	curtir: sinal binário.  |
|Requisitos relacionados  |  RF01, RF02, RF03 e RF04  |




## Matriz de Rastreabilidade
tabela baseada nos requisitos relacionados de cada requisito

Matriz de Rastreabilidade horizontal:
|    X    | RF01 | RF02 | RF03 | RF04 |FR05 |
|---------|------|------|------|------|-----|
| RF01    |      |      |      |      |     |
| RF02    |   X  |      |      |      |     |
| RF03    |   X  |      |      |   X  |     |
| RF04    |   X  |   X  |      |      |     |
| RF05    |   X  |   X  |  X   |   X  |     |


## Apêndices
* [Requisitos de usuários](https://github.com/marcoscouzads/ProjetoBloco-TP1-Marcos_Cassiano)

## Referências
* [Essentials of software Engineering, 4th Edition](https://learning.oreilly.com/library/view/essentials-of-software/9781284106077/xhtml/33_Chapter17.xhtml)
* [Materia utilizado nas aulas de projeto de bloco das etapas 1,2 e 3](https://drive.google.com/drive/folders/1d4j5hxGWy7kdHl_TT2c6EEHEl-h4Xu36)
* [Curso de engenharia de software - UNIVESP](https://www.youtube.com/watch?v=ciQ2FObc3tc&list=PLxI8Can9yAHfeoA_yMm9iKJVxQprljmL9&ab_channel=UNIVESP)
* [Bóson treinamentos - UML](https://www.youtube.com/watch?v=C3xYBT3o_5k&list=PLucm8g_ezqNqCRGHGHoacCo6N1bfN7hXZ&ab_channel=B%C3%B3sonTreinamentos)