# SPOTMUSIC

## Projeto de bloco TP 9
<br/>
Link para a rede social SPOTMUSIC: 
[AQUI](https://app-marcos-cassiano-pb-tp9.azurewebsites.net)

### Etapas anteriores 
- TP 1
[Git](https://github.com/marcoscouzads/ProjetoBloco-TP1-Marcos_Cassiano.git)
Metodologia de desenvolvimento 
[Relatorio](https://github.com/marcoscouzads/ProjetoBloco_TP9_Marcos_Cassiano/blob/master/RELATORIO/MetodologiaDeDesenvolvimento.md)
e Requisitos de softwares
[Relatorio](https://github.com/marcoscouzads/ProjetoBloco_TP9_Marcos_Cassiano/blob/master/RELATORIO/RequisitosDeSoftware.md)

 - TP 2 e TP 3
[Git](https://github.com/marcoscouzads/ProjetoBloco-TP3-Marcos_Cassiano.git)
Requisitos do Sistema
[Relatorio](https://github.com/marcoscouzads/ProjetoBloco_TP9_Marcos_Cassiano/blob/master/RELATORIO/RequisitosDeSistema.md)

 - TP 4 e TP 5
[Git](https://github.com/marcoscouzads/ProjetoBloco-TP5-Marcos_Cassiano-.git)
Diagramas de Classes e Componentes
[Relatorio](https://github.com/marcoscouzads/ProjetoBloco_TP9_Marcos_Cassiano/blob/master/RELATORIO/Diagramas.md)

 - TP6 e TP 7
[Git](https://github.com/marcoscouzads/ProjetoBloco_TP7_Marcos_Cassiano.git)
Inicio da construção da rede social SPOTMUSIC


### Descrição de cada uma das etapas do trabalho realizado utilizando o modelo em cascata:

 Na primeira etapa aprendi sobre os metodos existente sobre criação de softwares e como definir os requisitos necessarios para os clientes.
Logo após foi feita o levantamentos destes requisitos e sua descrição detalhada para definir os limites para a implementação das funcionalidades.
Nas etapas 4 e 5 foram feitos os diagramas para uma definição melhor das classes e componentes que iram ser utilizados no inicio da construção do projeto
As etapas 6 e 7 foram o inicio do projeto, e com ele a construção das necessidades e colocação de todos atributos de classe desenvolvidas até este momento.
Nesta ultima etapa foi o fechamento dos pontos faltantes como a divisão em camadas e funcionalidades basicas para uma rede social, como uma foto de perfil
e um feed de postagem, onde convencionei de chamar de spots, para fazer mais sentido com a rede social em questão.



### Uma crítica ao projeto desenvolvido avaliando o impacto que a utilização do modelo em cascata causou ao projeto:

Com o desenvolvimento em cascata tive um enorme problema com relaçao ao tempo para entrega e principalmente a limitação de conhecimento da tecnologia.
Diversas funcionalidades vislumbradas nas primeiras etapas tiveram que ser removidas para ser possivel entregar o projeto final com o minimo requerido.
toda a documentação gerada até o momento terá que ser modificada para se adaptar ao que foi produzido como produto final. Sem duvidas o modelo de desenvolvimento
em cascata gera um enorme prejuizo pois faltando alguma funcionalidade, ou ela sendo diferente da que o cliente realmente queria se perde muito tempo
voltando para o inicio da construção do software.

# migrations

#### migrations dos models direto no mvc
dotnet ef migrations add addInitial --startup-project SpotMusic --project SpotMusic --context SpotMusicDBContext --output-dir Data\Migrations

dotnet ef database update --startup-project SpotMusic --project SpotMusic --context SpotMusicDBContext


#### migrations do identity direto no mvc
dotnet ef migrations add addIdentity --startup-project SpotMusic --project SpotMusic --context IdentityDBContext --output-dir Areas\IdentityData\Migrations

dotnet ef database update --startup-project SpotMusic --project SpotMusic --context IdentityDBContext

