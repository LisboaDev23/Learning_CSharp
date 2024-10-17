﻿public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                Console.WriteLine(Dividir(number1, number2));
                DepositarSalario(-50);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("DIVISÃO POR 0 INVÁLIDA! " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("FORMATO INVÁLIDO! VERIFIQUE SE O NÚMERO DIGITADO É UM INTEIRO! " + e.Message);
            }
            catch(SaldoNegativoException e){
                Console.WriteLine("ERRO NO DEPÓSITO! " + e.Message);
            }
            finally
            {
                Console.WriteLine("Fluxo encerrado!");
            }
        }
        public static int DepositarSalario (int deposito){
            if(deposito < 0){
                throw new SaldoNegativoException ();
            } else if (deposito == 0){
                throw new InvalidOperationException();
            }
            Console.WriteLine("Salário depositado no valor de " + deposito);
            return deposito;
        }
        public static int Dividir(int number1, int number2)
        {
            return number1 / number2;
        }
}