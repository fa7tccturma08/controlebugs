using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleBugs.Helpers.PajeObjects
{
    public class ManterUsuarioHelper : TelaHelper
    {

        public void PreencherDadosUsuario(String nome, String login, String senha)
        {
            try
            {
                implicitWaintById("formUsuarios");
                var campoNome = Driver.FindElement(By.Id("nome"));
                var campoLogin = Driver.FindElement(By.Id("login"));
                var campoSenha = Driver.FindElement(By.Id("senha"));


                implicitWaintById("nome");
                SetText(campoNome, nome);
                implicitWaintById("login");
                SetText(campoLogin, login);
                implicitWaintById("senha");
                SetText(campoSenha, senha);


            }
            catch
            {

                Console.WriteLine("Erro ao preencher os dados do usuário");
            }
        }

        public void SalvarUsuario()
        {
            try
            {
                implicitWaintById("btnSalvar");
                var botaoSalvar = Driver.FindElement(By.Id("btnSalvar"));

                clickObject(botaoSalvar);


            }
            catch
            {

                Console.WriteLine("Erro ao salvar os dados do usuário");
            }
        }


        public void RemoverUsuario(int id)
        {
            try
            {
                implicitWaintById("tableUsuarios:" + id + ":linkRemover");
                var botaoSalvar = Driver.FindElement(By.Id("tableUsuarios:" + id + ":linkRemover"));
                clickObject(botaoSalvar);


            }
            catch
            {

                Console.WriteLine("Erro ao remover os dados do usuário");
            }
        }

        public void AlterarUsuario(int id)
        {
            try
            {
                implicitWaintById("tableUsuarios:" + id + ":linkAlterar");
                var botaoSalvar = Driver.FindElement(By.Id("tableUsuarios:" + id + ":linkAlterar"));
                clickObject(botaoSalvar);


            }
            catch
            {

                Console.WriteLine("Erro ao alterar os dados do usuário");
            }
        }

    }
}
