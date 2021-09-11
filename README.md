#Projeto de bloco TP 9
<br/>
Link para a rede social SPOTMUSIC: [AQUI!!!](as.com)

## Etapas anteriores 

TP 1
Metodologia de desenvolvimento e Requisitos de softwares

TP 2 e TP 3
Requisitos do Sistema

TP 4 e TP 5
Diagramas de Classes e Componentes

TP6 e TP 7
Inicio da constru��o da rede social SPOTMUSIC


### Descri��o de cada uma das etapas do trabalho realizado utilizando o modelo em cascata:

 Na primeira etapa aprendi sobre os metodos existente sobre cria��o de softwares e como definir os requisitos necessarios para os clientes.
Logo ap�s foi feita o levantamentos destes requisitos e sua descri��o detalhada para definir os limites para a implementa��o das funcionalidades.
Nas etapas 4 e 5 foram feitos os diagramas para uma defini��o melhor das classes e componentes que iram ser utilizados no inicio da constru��o do projeto
As etapas 6 e 7 foram o inicio do projeto, e com ele a constru��o das necessidades e coloca��o de todos atributos de classe desenvolvidas at� este momento.
Nesta ultima etapa foi o fechamento dos pontos faltantes como a divis�o em camadas e funcionalidades basicas para uma rede social, como uma foto de perfil
e um feed de postagem, onde convencionei de chamar de spots, para fazer mais sentido com a rede social em quest�o.



### Uma cr�tica ao projeto desenvolvido avaliando o impacto que a utiliza��o do modelo em cascata causou ao projeto:

Com o desenvolvimento em cascata tive um enorme problema com rela�ao ao tempo para entrega e principalmente a limita��o de conhecimento da tecnologia.
Diversas funcionalidades vislumbradas nas primeiras etapas tiveram que ser removidas para ser possivel entregar o projeto final com o minimo requerido.
toda a documenta��o gerada at� o momento ter� que ser modificada para se adaptar ao que foi produzido como produto final. Sem duvidas o modelo de desenvolvimento
em cascata gera um enorme prejuizo pois faltando alguma funcionalidade, ou ela sendo diferente da que o cliente realmente queria se perde muito tempo
voltando para o inicio da constru��o do software.

# migrations

#### migrations dos models direto no mvc
dotnet ef migrations add addInitial --startup-project SpotMusic --project SpotMusic --context SpotMusicDBContext --output-dir Data\Migrations

dotnet ef database update --startup-project SpotMusic --project SpotMusic --context SpotMusicDBContext


#### migrations do identity direto no mvc
dotnet ef migrations add addIdentity --startup-project SpotMusic --project SpotMusic --context IdentityDBContext --output-dir Areas\IdentityData\Migrations

dotnet ef database update --startup-project SpotMusic --project SpotMusic --context IdentityDBContext

