# language: pt
@RealizarLogin
Funcionalidade: Manter Usuarios
	Eu como Administrador do bugtraker quero Manter os usuarios na aplicacao

@ConsultarUsuarios
Esquema do Cenario:  Consultar Usuarios Com Sucesso
	Quando eu realiso a consulta dos usuarios
	Entao O sistema exibe o formulario com os campos <Nome>, <Login> e <Senha>
	E as opções "Cancelar" e "Salvar"
	E Lista os usuários anteriomente cadastrados com os campos <Id> , <Nome> , <Login> , <Remover>,<Alterar>

	Exemplos:
		| ID  | Nome         | Login        | Ações             |
		| '1' | 'bugtracker' | 'bugtracker' | "Remover Alterar' |

@IncluirUsuariosComSucesso
Esquema do Cenario: Incluir Usuários com sucesso
	Quando eu preencho os campos  <Nome> , <Login> ou <Senha> de forma correta
	E seleciono a opção "Salvar"
	Entao O Sistema exibe a mensagem "Usuário Adicionado Com Sucesso!"
	E Exibe o usuário que foi adicionado na lista de usuários anteriormente cadastrados com os campos <Id> , <Nome> , <Login> , <Ações>

	Exemplos:
		| Nome         | Usuario           | Senha          |
		| 'Maria Jose' | 'mjose@gmail.com' | 'Resource@123' |

@IncluirUsuariosInformandoCampoObrigatorioNaoPreenchido
Esquema do Cenario: Incluir Usuários sem preencher um campo obrigatório
	Quando eu deixo de  preencher um dos campos  <Nome> , <Login> ou <Senha> de forma correta
	E escolho a opção "Salvar"
	Entao O Sistema emite o alerta  "<campo> :  campo é obrigatório"

	Exemplos:
		| Nome | Usuario           | Senha          |
		| ''   | 'mjose@gmail.com' | 'Resource@123' |

@IncluirUsuariosInformandoCampoFormatoinvalido
Esquema do Cenario:  Incluir Usuários informando o campo com formato inválido
	Quando eu preencho o campo <senha> com uma quantidade de caracteres menor que 4 digitos
	E elejo a opção "Salvar"
	Entao O sistema informa ao usuário com a  mensagem "O campo <senha> Não e forte o bastante"
	

	Exemplos:
		| Nome         | Usuario           | Senha |
		| 'Maria Jose' | 'mjose@gmail.com' | '123' |

@EditarUsuariosComSucesso
Esquema do Cenario: Editar Usuários com sucesso
	Quando Eu seleciono um usuário que já cadastrado anteriomente
	E eu preencho um dos campos  <Nome> , <Login> ou <Senha> de forma correta
	E opto pela a opção "Salvar"
	Entao O Sistema externa a mensagem "Usuário Adicionado Com Sucesso!" para o usuario
	E exibe o usuário com as informações alteradas na lista de usuários cadastrados com os campos <Id> , <Nome> , <Login> , <Ações>

	Exemplos:
		| Nome         | Usuario           | Senha          |
		| 'Maria Jose' | 'mjose@gmail.com' | 'Resource@123' |

@EditarUsuariosInformandoCampoObrigatorioNaoPreenchido
Esquema do Cenario: Editar Usuários sem preencher um campo obrigatório
	Quando Eu seleciono um usuário já cadastrado
	E eu deixo de  preencher um dos campos  <Nome> , <Login> ou <Senha> de forma correta
	E seleciono a opção "Salvar"
	Entao O Sistema mostra a mensagem  "<campo> :  campo é obrigatório" para o usuario
	E Lista os usuários já cadastrados com os campos <Id> , <Nome> , <Login> , <Ações>

	Exemplos:
		| Nome | Usuario           | Senha          |
		| ''   | 'mjose@gmail.com' | 'Resource@123' |

@EditarUsuariosInformandoCampoFormatoinvalido
Esquema do Cenario:  Editar Usuários informando o campo com formato inválido
	Quando Eu seleciono um usuário anteriomente cadastrado
	E eu preencho o campo <senha> com uma quantidade de caracteres menor que 4 digitos
	E seleciono a opção "Salvar"
	Entao O sistema reporta a mensagem "O campo <senha> Não e forte o bastante"
	E Lista os usuários já cadastrados com os campos <Id> , <Nome> , <Login> , <Ações>

	Exemplos:
		| Nome         | Usuario           | Senha |
		| 'Maria Jose' | 'mjose@gmail.com' | '123' |

@RemoverUsuarioComSucesso
Esquema do Cenario:  Remover um usuario com sucesso
	Quando eu seleciono um usuario que não esta associado a um Bug da lista de usuarios disponiveis
	E seleciono a opção Remover
	Entao o Sistema retorna a mensagem : "Usuário Removido Com Sucesso!"

	Exemplos:
		| Nome           | Usuario           | Senha |
		| 'Jose Emanuel' | 'mjose@gmail.com' | '123' |