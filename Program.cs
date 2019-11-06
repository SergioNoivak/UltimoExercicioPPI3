using System;

namespace projeto3
{
    class Program
    {
        static void Main(string[] args)
        {
            while(1==1){
                Menu.exibir();
                int opcaoEscolhida = Menu.lerOpcao();
                System.Console.Clear();
                Menu.exibirFormulario(opcaoEscolhida);
                if(opcaoEscolhida==4)
                 break;
            }       
            
            
            
        }
    }
}
