namespace Robozinho
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("digite o tamanho do grid  x: ");

            int gridx = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Digite o tamanho do grid y: ");

            int gridy = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite a posicao inicial x: ");

            int posinicialx = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite a posicao inicial y: ");

            int posinicialy = Convert.ToInt32(Console.ReadLine());

            Console.Write("insira a direcao do robo em (N) (S) (L) (O): ");

            Char direcao = Convert.ToChar(Console.ReadLine());

            Console.Write("digite o comando para o valor fazer: ");

            string comando = Console.ReadLine();

            char[] comandochar = comando.ToCharArray();

            for (int i = 0; i < comandochar.Length; i++)
            {
                if (comandochar[i] == 'M')
                {
                    if (direcao == 'N')
                    {
                        posinicialy++;
                    }
                    else if (direcao == 'S')
                    {
                        posinicialy--;
                    }
                    else if (direcao == 'L')
                    {
                        posinicialx++;                 // -- e ++ volta casa avanca casa ou sobe casa ou desce casa
                    }
                    else if (direcao == 'O')
                    {
                        posinicialx--;
                    }



                }

                else if (comandochar[i] == 'E')
                {
                    if (direcao == 'N')
                    {
                        direcao = 'L';
                    }

                    else if (direcao == 'S')
                    {
                        direcao = 'O';
                    }



                else if (direcao == 'L')
                {
                    direcao = 'S';
                }

                else if (direcao == 'O')
                {
                    direcao = 'N';
                }
            }


                else if (comandochar[i] == 'D')
                {
                    if (direcao == 'S')
                    {
                        direcao = 'O';
                    }

                    else if (direcao == 'N')
                    {
                        direcao = 'L';
                    }




                    else if (direcao == 'O')
                    {
                        direcao = 'N';
                    }

                    else if (direcao == 'L')
                    {
                        direcao = 'S';
                    }

                }



            }
            Console.WriteLine("POSICAO INICIAL X " + posinicialx + "posicao inicial Y :" + posinicialy + " direcao " + direcao);
            Console.ReadLine();


            //////////// SEGUNDO ROBO

            Console.Write("digite a posicao inicial x: ");

            int posinicialx2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("digite a posicao inicial y: ");

            int posinicialy2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("insira a direcao do robo em (N) (S) (L) (O): ");

            Char direcao2 = Convert.ToChar(Console.ReadLine());

            Console.Write("digite o comando para o valor fazer: ");

            string comando2 = Console.ReadLine();

            char[] comandochar2 = comando2.ToCharArray();

            for (int i = 0; i < comandochar2.Length; i++)
            {
                if (comandochar2[i] == 'M')
                {
                    if (direcao2 == 'N')
                    {
                        posinicialy2++;
                    }
                    else if (direcao2 == 'S')
                    {
                        posinicialy2--;
                    }
                    else if (direcao2 == 'L')
                    {
                        posinicialx2++;                 // -- e ++ volta casa avanca casa ou sobe casa ou desce casa
                    }
                    else if (direcao2 == 'O')
                    {
                        posinicialx2--;
                    }



                }

                else if (comandochar2[i] == 'E')
                {
                    if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }

                    else if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }



                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }

                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }
                }


                else if (comandochar2[i] == 'D')
                {
                    if (direcao2 == 'S')
                    {
                        direcao2 = 'O';
                    }

                    else if (direcao2 == 'N')
                    {
                        direcao2 = 'L';
                    }




                    else if (direcao2 == 'O')
                    {
                        direcao2 = 'N';
                    }

                    else if (direcao2 == 'L')
                    {
                        direcao2 = 'S';
                    }

                }



            }
            Console.WriteLine("POSICAO INICIAL X " + posinicialx2 + "posicao inicial Y :" + posinicialy2 + " direcao " + direcao2);
            Console.ReadLine();
        }    
    }
}