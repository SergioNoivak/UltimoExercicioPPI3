using System;

namespace projeto3
{
    
    class Cadastrador{
    
        public int cadastrarUsuario(Usuario u){

                if(u.senha==""||u.email=="")
                   return (int)Erros.UsuarioInvalido;

                System.IO.File.AppendAllText("C:/Users/sergi/Documents/PRONATEC/PPI 3 jogos/projeto3/data/usuarios.txt",u.prepararGravacao());
                return (int)Erros.sucesso;


            
        }


    }


}