Funcionalidade: Gerenciar canais de comunicação

  Como usuário do sistema
  Eu quero cadastrar um novo canal de comunicação especificando o seu tipo
  video ou audio

 
 Cenário: Cadastrar novo canal de video ou audio
    Dado que preciso cadastrar um canal de audio ou video
    Quando preencho o campo Nome com "Canal de Video" e o tipo como 1
    E recebo os dados preenchidos pela tela
    Então cadastro um novo Canal de video   
    E o canal "Canal de Video" aparece na listagem de canais cadastrados