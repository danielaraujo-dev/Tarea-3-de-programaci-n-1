using System;

namespace Tarea_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumador = 0;
            string dato = "";
            double PesoCanino = 0.0;
            int TamañoCanino = 0;
            int actividadCanina = 0;
            int contador = 0;
            int contado2 = 0;
            int contador3 = 0;

            while (contador3 == 0)
            {



                Console.WriteLine("Bienvenido al Sistema");
                Console.WriteLine("Por favor indique el peso de su canino en Kg");
                Console.WriteLine("Y recuerde utilizar valores numéricos durante toda la ejecución de este programa");
                dato = Console.ReadLine();
                PesoCanino = Convert.ToDouble(dato);

                Console.WriteLine("Ahora, Indique el tamaño de su canino");
                Console.WriteLine("Utilice: ");
                Console.WriteLine(" 1 = para perros miniatura ");
                Console.WriteLine(" 2 = para perros pequeños ");
                Console.WriteLine(" 3 = para perros medianos ");
                Console.WriteLine(" 4 = para perros grander ");
                dato = Console.ReadLine();
                TamañoCanino = Convert.ToInt32(dato);

                Console.WriteLine("Ahora, Indique la Actividad física de su Mascota");
                Console.WriteLine("Utilice: ");
                Console.WriteLine(" 1 = Alta ");
                Console.WriteLine(" 2 = Normal ");
                Console.WriteLine(" 3 = baja ");
                dato = Console.ReadLine();
                actividadCanina = Convert.ToInt32(dato);

                Console.WriteLine("Su perro es un Cachorro o un adulto");
                Console.WriteLine("Utilice: ");
                Console.WriteLine(" 1 para Cachorro ");
                Console.WriteLine(" 2 para adulto ");
                dato = Console.ReadLine();
                sumador = Convert.ToInt32(dato);

                if (sumador == 2)
                {

                    while (contador == 0)
                    {
                        switch (TamañoCanino)
                        {

                            case 1:
                                if (PesoCanino >= 2 && PesoCanino <= 5 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 60 y 115 gramos de alimento");
                                }
                                if (PesoCanino >= 2 && PesoCanino <= 5 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 55 y 100 gramos de alimento");
                                }
                                if (PesoCanino >= 2 && PesoCanino <= 5 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 45 y 85 gramos de alimento");
                                }
                                if (PesoCanino > 5)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                if (PesoCanino < 2)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                break;

                            case 2:
                                if (PesoCanino >= 5 && PesoCanino <= 10 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 115 y 190 gramos de alimento");
                                }
                                if (PesoCanino >= 5 && PesoCanino <= 10 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 100 y 170 gramos de alimento");
                                }
                                if (PesoCanino >= 5 && PesoCanino <= 10 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 85 y 145 gramos de alimento");
                                }
                                if (PesoCanino > 10)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                if (PesoCanino < 5)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                break;

                            case 3:
                                if (PesoCanino >= 10 && PesoCanino <= 15 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 190 y 255 gramos de alimento");
                                }
                                if (PesoCanino >= 5 && PesoCanino <= 10 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 170 y 225 gramos de alimento");
                                }
                                if (PesoCanino >= 5 && PesoCanino <= 10 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 145 y 195 gramos de alimento");
                                }
                                if (PesoCanino > 10)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                if (PesoCanino < 5)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                break;

                            case 4:
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 255 y 380 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 225 y 330 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 195 y 285 gramos de alimento");
                                }


                                if (PesoCanino >= 25 && PesoCanino <= 40 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 380 y 535 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 330 y 475 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 285 y 410 gramos de alimento");
                                }

                                if (PesoCanino >= 40 && PesoCanino <= 55 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 535 y 680 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 475 y 600 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 410 y 520 gramos de alimento");
                                }

                                if (PesoCanino >= 55 && PesoCanino <= 70 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 680 y 820 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 600 y 720 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 520 y 620 gramos de alimento");
                                }

                                if (PesoCanino >= 70 && PesoCanino <= 90 && actividadCanina == 1)
                                {
                                    Console.WriteLine("Su perro debe comer entre 820 y 985 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 2)
                                {
                                    Console.WriteLine("Su perro debe comer entre 720 y 870 gramos de alimento");
                                }
                                if (PesoCanino >= 15 && PesoCanino <= 25 && actividadCanina == 3)
                                {
                                    Console.WriteLine("Su perro debe comer entre 620 y 750 gramos de alimento");
                                }
                                if (PesoCanino > 90)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                if (PesoCanino < 15)
                                {
                                    Console.WriteLine("Recomendamos que lleve a su mascota a un especialista");
                                }
                                break;
                            default:
                                Console.WriteLine("Por favor introduzca un Caracter Válido. Y reinicie el sistema");
                                contador++;
                                break;

                        }
                    }
                }
                if (sumador == 1)
                {
                    while (contado2 == 0)
                    {
                        switch (TamañoCanino)
                        {
                            case 1:
                                if (PesoCanino == 2)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 50 gramos de comida");
                                    Console.WriteLine("3 meses = 60 gramos de comida ");
                                    Console.WriteLine("4 meses = 60 gramos de comida ");
                                    Console.WriteLine("5 meses = 60 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 60 gramos de comida ");
                                }
                                else
                                {
                                    Console.WriteLine("Consulte con un Especialista");
                                }
                                break;

                            case 2:
                                if (PesoCanino == 5)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 95 gramos de comida");
                                    Console.WriteLine("3 meses = 110 gramos de comida ");
                                    Console.WriteLine("4 meses = 115 gramos de comida ");
                                    Console.WriteLine("5 meses = 115 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 110 gramos de comida ");
                                }
                                if (PesoCanino == 10)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 155 gramos de comida");
                                    Console.WriteLine("3 meses = 185 gramos de comida ");
                                    Console.WriteLine("4 meses = 195 gramos de comida ");
                                    Console.WriteLine("5 meses = 190 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 180 gramos de comida ");
                                }
                                else
                                {
                                    Console.WriteLine("Consulte con un Especialista");
                                }
                                break;

                            case 3:
                                if (PesoCanino == 17)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 215 gramos de comida");
                                    Console.WriteLine("3 meses = 265 gramos de comida ");
                                    Console.WriteLine("4 meses = 285 gramos de comida ");
                                    Console.WriteLine("5 meses = 285 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 280 gramos de comida ");
                                }
                                else
                                {
                                    Console.WriteLine("Consulte con un Especialista");
                                }
                                break;
                            case 4:
                                if (PesoCanino == 25)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 270 gramos de comida");
                                    Console.WriteLine("3 meses = 350 gramos de comida ");
                                    Console.WriteLine("4 meses = 375 gramos de comida ");
                                    Console.WriteLine("5 meses = 375 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 370 gramos de comida ");
                                }
                                if (PesoCanino == 32)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 300 gramos de comida");
                                    Console.WriteLine("3 meses = 400 gramos de comida ");
                                    Console.WriteLine("4 meses = 445 gramos de comida ");
                                    Console.WriteLine("5 meses = 450 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 450 gramos de comida ");
                                }
                                if (PesoCanino == 40)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 355 gramos de comida");
                                    Console.WriteLine("3 meses = 475 gramos de comida ");
                                    Console.WriteLine("4 meses = 525 gramos de comida ");
                                    Console.WriteLine("5 meses = 530 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = 530 gramos de comida ");
                                }
                                if (PesoCanino == 50)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 405 gramos de comida");
                                    Console.WriteLine("3 meses = 545 gramos de comida ");
                                    Console.WriteLine("4 meses = 610 gramos de comida ");
                                    Console.WriteLine("5 meses = 625 gramos de comida ");
                                    Console.WriteLine("6 -12 meses = porciones de adulto de comida ");
                                }
                                if (PesoCanino == 60)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 450 gramos de comida");
                                    Console.WriteLine("3 meses = 605 gramos de comida ");
                                    Console.WriteLine("4 meses = 685 gramos de comida ");
                                    Console.WriteLine("5 meses = porciones de adulto de comida ");
                                    Console.WriteLine("6 -12 meses = porciones de adulto de comida ");
                                }
                                if (PesoCanino == 70)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 450 gramos de comida");
                                    Console.WriteLine("3 meses = 670 gramos de comida ");
                                    Console.WriteLine("4 meses = porciones de adulto de comida ");
                                    Console.WriteLine("5 meses = porciones de adulto de comida ");
                                    Console.WriteLine("6 -12 meses = porciones de adulto de comida ");
                                }
                                if (PesoCanino == 90)
                                {
                                    Console.WriteLine("Su perro deberá ingerir esta cantidad de alimento al cumplir: ");
                                    Console.WriteLine("2 meses = 580 gramos de comida");
                                    Console.WriteLine("3 meses = porciones de adulto de comida ");
                                    Console.WriteLine("4 meses = porciones de adulto de comida ");
                                    Console.WriteLine("5 meses = porciones de adulto de comida ");
                                    Console.WriteLine("6 -12 meses = porciones de adulto de comida ");
                                }
                                else
                                {
                                    Console.WriteLine("Consulte con un Especialista");
                                }
                                Console.WriteLine("Recuerda consultar con tu veterinario de confianza");
                                break;
                            default:
                                Console.WriteLine("Ingrese un valor válido.");
                                contado2++;
                                break;

                        }
                    }

                }
                Console.WriteLine("Desea seguir. Presione: ");
                Console.WriteLine("0 = si");
                Console.WriteLine("1 = no");
                dato = Console.ReadLine();
                contador3 = Convert.ToInt32(dato);
            }
        }





        }

    }

