using Cadastro_Pessoa_FS1.Classes;

//ARQUIVO TXT PARA PESSOA FÍSICA

PessoaFisica novaPf = new PessoaFisica();

novaPf.nome = "Moises";

Console.WriteLine( $"{novaPf.nome}" );

StreamWriter sw = new StreamWriter( $"{novaPf.nome}.txt" );

sw.Write( novaPf.nome );

sw.Close();

using ( StreamWriter sw2 = new StreamWriter( $"{novaPf.nome}.txt" ) )
{
    sw2.WriteLine( $"{novaPf.nome}" );
}