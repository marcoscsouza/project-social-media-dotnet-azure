# Spotmusic
## Requisitos do Sistema para a rede social para m�sicos


### Sum�rio
* Prop�sito do Documento
* Escopo do projeto
* Requisitos de Usu�rio
  * [RF01] Manter o cadastro do usu�rio
  * [RF02]  Autentica��o
  * [RF03]  Fazer conex�o com outros usu�rios
  * [RF04]  Publica��o de fotos
  * [RF05]  Intera��o com outros usu�rios
* Requisitos do Sistema
  * [RF01]  Criar o perfil na rede social 
  * [RF02]  Criar grupos na rede social
  * [RF03]  Cria��o de Post no Feed de Not�cias
  * [RF04]  Criar uma galeria de imagens
  * [RF05]  Curtir Posts de outros usu�rios
  * [RF06]  Cadastrar eventos 
  * [RF07]  Conversar com outros usu�rios
  * [RF08]  Sugest�o de amizades
  * [RF09]  Denunciar publica��es com irregularidades
  * [RF10]  Bloqueio de usu�rios que cometem a��es irregulares
* Matriz de Rastreabilidade
* Ap�ndices
* Refer�ncias

### Spotmusic
### 1. Prop�sito do Documento
O objetivo deste documento � especificar as funcionalidades necess�rias para o desenvolvimento da rede social para m�sicos. Definir as restri��es sobre o uso de suas tecnologias e ferramentas.Tamb�m, fornecer os detalhes necess�rios para o desenvolvimento de funcionalidades e cria��o de diagramas. Assegurar que as funcionalidades aqui descritas far�o parte do entreg�vel ao final do projeto. Assegurar a passagem de conhecimento de maneira objetiva e descritiva sobre as necessidades do produto.

### 2. Escopo do projeto
Criar uma rede social para m�sicos. Com diversos m�sicos espalhados por diversos locais, eles acabam n�o se conhecendo e por consequ�ncia as vezes ficam com dificuldades para adicionar algu�m em sua banda ou para procurar algu�m interessado a participar de algum projeto. Com est� rede social o principal objetivo ser� unir todos os m�sicos, fazendo conex�o de todos por estilo musical, prop�sitos como montar banda ou criar algum *single* e o mais importante compartilhar momentos e experi�ncias. A rede social Tamb�m prop�e dar uma imers�o muito superior para os amantes de m�sica, podendo no futuro postar seus show para uma melhor divulga��o, compartilhar m�sicas para que outros possam contribuir para a sua cria��o, grupos de instrumentos para compartilhar dicas e fotos e muito mais.

### 3. Requisitos de Usu�rio
- ####  [RF01]  Manter o cadastro do usu�rio
Ao m�sico deve ser poss�vel cadastrar seus dados como idade, banda ao qual pertence, m�sicas que fez ou participou e demais informa��es relacionados a m�sica.

- ####  [RF02] Cadastro de grupos
Ao m�sico deve ser poss�vel de se cadastrar e criar diferentes grupos sejam de g�neros musicais, regi�es ou da sua banda.

- ####  [RF03] Fazer conex�o com outros usuarios
A rede social deve ser capaz de conectar os usu�rios seja incluindo no seu v�nculo de amigos ou participando de grupos.

- ####  [RF04] Publica��o de fotos
Ao m�sico deve ser poss�vel publicar as suas fotos na sua galeria de imagens, perfil ou grupos.

- ####  [RF05] Intera��o com outros usu�rios
A rede social deve ter uma p�gina de publica��es onde o usu�rio possa interagir com as publica��es de seus grupos e a outros m�sicos de que estejam ligados a seus ciclo de amizades.

- #### [RF06] Cadastrar eventos 
Ao m�sico deve ser poss�vel registrar um evento com local, hora e dia para convidar outros m�sicos dessa rede social, o sistema deve ser capaz de avisar sobre o evento com anteced�ncia.

- #### [RF07] Conversar com outros usu�rios
O sistema deve ser capaz de ter um meio de comunica��o privada entre dois usu�rios onde possam trocar mensagens.

- #### [RF08] Sugest�o de amizades
O sistema deve ser capaz de sugerir para o usu�rio amigos que talvez ele possa conhecer com base na quantidade de amigos em comum.

- #### [RF09] Denunciar publica��es com irregularidades
O sistema deve ter a capacidade de por meio de denuncias, excluir uma publica��o que contenha irregularidade.

- #### [RF10] bloqueio de usu�rios que cometem a��es irregulares
Para o caso de algum usu�rio cometer algum ato criminoso ou suspeito, poder� ser bloqueado por quem n�o quiser mais ter v�nculo.

### 4. Requisitos do Sistema

- #### RF01 
|Requisito  | Criar o perfil na rede Social |
|----------|----------------|
|Atores   | Usu�rio e Sistema.|
|Pr�-condi��o   | N�o pussuir um perfil na rede.|
|Fluxo b�sico | � O usu�rio acessa a interface para criar um perfil na rede social. <br>  �	O usu�rio deve informa seu nome. <br> �	O usu�rio deve informa seu e-mail. <br> �	O usu�rio deve informa uma senha. <br> �	O usu�rio deve informa sua data de nascimento. <br> �	O usu�rio deve informa seu endere�o. <br> �	O usu�rio deve informar se esta em alguma banda. <br> � O usu�rio deve informar seu(s) instrumento(s) que utiliza. <br> � O usu�rio executa a cria��o do perfil e o sistema redireciona o usu�rio para a p�gina principal. |
|P�s condi��o  |	Um perfil � criado com os dados informados pela pessoa e j� passa a ser v�lido. |
|Fluxo alternativo  | �	A pessoa n�o informa um dos dados solicitados na interface de cria��o de perfil e ent�o executa a cria��o do perfil, quando isso ocorrer, a mensagem �{nomeDoCampo} � obrigat�rio(a)� deve aparecer onde estiver faltando. <br> Por exemplo: �Nome � obrigat�rio(a)� ou �Data de nascimento � obrigat�rio(a)�  <br> �	A pessoa informa um e-mail n�o v�lido, deve aparecer o seguinte erro: "E-mail inv�lido! Tente novamente." <br>  �	A pessoa informa um e-mail que j� est� associado a algum perfil. Quando a pessoa executar a cria��o do perfil, a mensagem �Esse e-mail j� est� associado a um perfil� deve ser exibida. |
|Dados    |  �	Nome: Texto, m�ximo de 100 caracteres, n�o pode conter n�meros. <br> �	Senha: Mais de 8 caracteres. <br> �	Data de nascimento: Data v�lida. Permite no m�nimo 10 anos. <br> �	Endere�o: Logradouro, n�mero, complemento, bairro, cidade e estado. Todos os dados do tipo texto. <br> �	Nome da banda que participa e descri��o da mesma: texto at� no m�ximo 500 caracteres.  |
|Requisitos relacionados  | 	Nenhum |

- #### RF02 
|Requisito | Autentica��o|
|--------|----------------|
|Atores   | Usu�rio, Sistema de email externo e sistema|
|Pr�-condi��o   | Ter feito uma conta na rede social|
|Fluxo b�sico | � O usu�rio deve clicar em enviar codigo de autentica��o pelo email. <br>  �	O usu�rio deve digitar o email usado no cadastro da conta. <br>  �	A rede social deve pedir para o usu�rio digitar o seu email em dois campos, para confirmar que o email estar correto. <br>  �	O usu�rio deve acessar seu email usado no cadastro para acessar o link de confirma��o de cadastro. <br>  �	O usu�rio deve usar o c�digo informado em seu email no campo de preenchimento do codigo na rede social. <br>  �	O usu�rio ap�s confirmar seu cadastro no email, deve refazer o login na rede social.  |
|P�s condi��o  |	O usu�rio n�o validar sua conta. |
|Fluxo alternativo  | �	O usu�rio n�o aciona a fun��o de enviar email para confirma��o, a rede social ir� limitar a conta para eitar uso indevido. <br>  �	O usu�rio tentar digitar o c�digo de confirma��o errado 3 vezes, ficar� impedido de fazer uma nova tentativa nas pr�ximas 24 horas. <br>  �	O usu�rio informa email diferente do usado no cadastro da conta, mensagem de erro aparecer�: "E-mail inv�lido! utilize o mesmo da coonta cadastrada." |
|Dados    |  �	C�gido: Texto, m�ximo de 8 caracteres, pode conter n�meros e caracteres especiais. <br> � Email: texto, m�ximo 100 caracteres, deve conter o caractere "@" para ser definido como email.  |
|Requisitos relacionados  |  RF01  |

- #### RF03 
|Requisito | Cria��o de Post no Feed de Not�cias|
|--------|----------------|
|Atores   | Usu�rios, redes externas e Sistema |
|Pr�-condi��o   | Ter perfil na rede social e arquivo ou link compat�vel com a rede.|
|Fluxo b�sico | � O usu�rio acessa a p�gina principal. <br>  �	O usu�rio informa que tipo de post deseja fazer. <br> Exemplos: <br>  1- apenas um texto. <br> 2- uma imagem. <br> 3- um link externo. <br>  � O usu�rio informa o tipo de privacidade do post, se ser� p�blico ou apenas para amigos. <br>  � O usu�rio poder� marcar seus amigos nas postagens. <br> |
|P�s condi��o  |	O post criado poder� ser apagado ou alterado. |
|Fluxo alternativo  | � O usu�rio tentar criar um post sem nenhum tipo de dado ou informa��o, n�o poder� compartilhar. <br>  �O usu�rio tentar marcar pessoa que n�o esteja no seu vinculo de amizade, n�o ir� aparecer como dispon�vel para marca��o. <br>  � o usu�rio anexar link ou arquivo incompat�vel, aparecer� a mensagem de erro: "N�o compat�vel.". e ser� ignorado. |
|Dados    |  �	texto do post: Texto, m�ximo de 2000 caracteres. <br>  � Imagem: apenas nos formatos suportados, "jpg", "png" e "gif". Tamanho m�ximo de 2mb. <br>  � Link: Apenas de sites seguros e sem arquivo para download.  |
|Requisitos relacionados  |  RF01 e RF04  |

- #### RF04  
|Requisito | Criar uma galeria de imagens|
|--------|----------------|
|Atores   | Usu�rio, hardware do usu�rio e sistema|
|Pr�-condi��o   | Ter perfil na rede social|
|Fluxo b�sico | � O usu�rio acessa o menu de imagens e pode escolher postar uma foto na sua galeria pessoal. <br>  � O usu�rio pode escolher as fotos armazenadas dentro do seu dispositivo. <br>  � o usuario pode informa na foto:<br> 1- titulo para a foto; <br> 2- Data da foto; <br> 3- local da foto; <br> 4- descri��o para foto.<br> �	O usu�rio pode criar albuns para agrupar as fotos. <br> � O usu�rio poder� marcar seus amigos na imagem. <br>  � O usu�rio poder� usar alguma imagem da galeria para colocar como foto de perfil. |
|P�s condi��o  |	Imagem � postada na galeria e pode ser usada para ser compartilhada pelo usu�rio. |
|Fluxo alternativo  | � O usu�rio tentar postar a foto em dois albuns, ser� selecionado apenas o ultimo escolhido. <br>  � O usu�rio tentar marcar duas vezes a mesma pessoa na imagem, ser� ignorado. <br>  � O usu�rio informar mais de um lugar na imagem, ser� alterada para a nova localiza��o. |
|Dados    |  �	Titulo da foto: Texto, m�ximo de 50 caracteres. <br>  � local da foto: Cidade, Estado e Pa�s. <br>  � Imagem: apenas nos formatos suportados, "jpg", "png" e "gif". Tamanho m�ximo de 2mb. <br> |
|Requisitos relacionados  |  RF01 E RF02  |

- #### RF05    
|Requisito | Curtir Posts de outros usu�rios |
|--------|----------------|
|Atores   | Usu�rios e Sistema|
|Pr�-condi��o   | Ter perfil na rede social, ser amigo do outro usu�rio ou fazer parte do mesmo grupo.|
|Fluxo b�sico | � Uma pessoa acessa a p�gina principal da rede social. <br> � O usu�rio navegando pelo feed de not�cias, poder� curtir posts dos usu�rios que fazem parte do seu vinculo de amigos. <br> � O usu�rio dentro dos grupos poder� curtir os posts de outros usu�rios mesmo n�o sendo do seu vinculo de amigos. <br> � O post que tiver mais curtidas ter� mais visualiza��o. |
|P�s condi��o  |	O usu�rio poder� tirar seu curtir quando quiser. |
|Fluxo alternativo  | � O usu�rio curtir mais de uma vez a mesma postagem, o sistema reconhecer� como tirar o curtir. <br> � O usu�rio fazer muitas curtidas consecutivas, o sistema bloquear� o usu�rio por um tempo determinado. <br> � o usu�rio permanecer com o bot�o de curtir ativado por mais de 5 segundos, sistema ir� ignorar curtida. |
|Dados    |  �	curtir: sinal bin�rio.  |
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


## Ap�ndices
* [Requisitos de usu�rios](https://github.com/marcoscouzads/ProjetoBloco-TP1-Marcos_Cassiano)

## Refer�ncias
* [Essentials of software Engineering, 4th Edition](https://learning.oreilly.com/library/view/essentials-of-software/9781284106077/xhtml/33_Chapter17.xhtml)
* [Materia utilizado nas aulas de projeto de bloco das etapas 1,2 e 3](https://drive.google.com/drive/folders/1d4j5hxGWy7kdHl_TT2c6EEHEl-h4Xu36)
* [Curso de engenharia de software - UNIVESP](https://www.youtube.com/watch?v=ciQ2FObc3tc&list=PLxI8Can9yAHfeoA_yMm9iKJVxQprljmL9&ab_channel=UNIVESP)
* [B�son treinamentos - UML](https://www.youtube.com/watch?v=C3xYBT3o_5k&list=PLucm8g_ezqNqCRGHGHoacCo6N1bfN7hXZ&ab_channel=B%C3%B3sonTreinamentos)