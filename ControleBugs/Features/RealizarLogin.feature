# language: pt
@RealizarLogin
Funcionalidade: Logar
	Eu como usuario do bugtraker quero realizar login na aplicacao

@RealizarLoginComSucesso
Esquema do Cenario: Login Realizado com Sucesso
	Quando  eu preencho o <login> e a <senha> validos
	E seleciono a opcao logar 
	Entao o sistema retornara o sistema apresenta  a funcionalidade de edição de usuários

	Exemplos:
		| login       | senha          |
		| 'bugtraker' | 'Resource@123' |

@CamposObrigatoriosNaoInformados
Esquema do Cenario:  Campos Obrigatorios Nao Informados
	Quando eu não preencho o <login> e a <senha> 
	E tento efetuar login no sistema 
	Entao o sistema retornara a mensagem "Login:campo é obrigatório"

	Exemplos:
		| login | senha |
		| ''    | ''    |

@CampoLoginOuSenhaInvalidos
Esquema do Cenario: Campo Login ou Senha Invalido
	Quando  eu preencho o <login> e a <senha> com valores invalidos
	E seleciono a opcao logar 
	Entao o sistema aresenta  mensagem "Login ou senha inválidos"

	Exemplos:
		| login       | senha |
		| 'bugtraker' | '123' |