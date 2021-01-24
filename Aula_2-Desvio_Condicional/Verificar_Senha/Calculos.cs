using System;
using System.Collections.Generic;
using System.Text;

namespace Verificar_Senha
{
    class Calculos
    {
        public string compararSenha( string senha, string senha_2 )
        {
            if (senha.Equals(senha_2) == true)
            {
                return "Senhas Digitadas Corretamente";
            }

            return "Senhas Não Conferem. Tete Novamente mais tarde.";
        }
    }
}
