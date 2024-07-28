using System;

class Program
{
    static void Main()
    {
        int vitorias = 120;
        int derrotas = 69;
        string resultado = NivelRanqueadas(vitorias, derrotas);
        Console.WriteLine(resultado);
    }

    static string NivelRanqueadas(int vitorias, int derrotas)
    {
        // Calcula o saldo de vitórias
        int saldoVitorias = vitorias - derrotas;

        // Determina o nível com base no saldo de vitórias
        string nivel;

        if (saldoVitorias < 10)
        {
            nivel = "Ferro";
        }
        else if (saldoVitorias >= 11 && saldoVitorias <= 20)
        {
            nivel = "Bronze";
        }
        else if (saldoVitorias >= 21 && saldoVitorias <= 50)
        {
            nivel = "Prata";
        }
        else if (saldoVitorias >= 51 && saldoVitorias <= 80)
        {
            nivel = "Ouro";
        }
        else if (saldoVitorias >= 81 && saldoVitorias <= 90)
        {
            nivel = "Diamante";
        }
        else if (saldoVitorias >= 91 && saldoVitorias <= 100)
        {
            nivel = "Lendário";
        }
        else
        {
            nivel = "Imortal";
        }

        // Retorna a mensagem de saída
        return $"O Herói tem um saldo de {saldoVitorias} está no nível de {nivel}!";
    }
}