using System;

namespace projeto3
{
    class Usuario{
        private string _email;        
        private string _senha ;

        public string email
        {
            get => _email;
            set => _email = value;
        }

        public string senha{
            get => _senha;
        }
        //Construtor serve para inicializar valores padrão
        public Usuario(string email,string senha){
            
            this._email = email;
            this._senha = senha;
        }

        public string prepararGravacao(){
            return this._email+"\n"+this.senha+"\n";
        }


    }
}