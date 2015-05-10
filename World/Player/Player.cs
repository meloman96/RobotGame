using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameProject.World.Entity;

namespace GameProject.World.Player
{
    {
        //private double Speed = 0.2;
        //public double Current_Points = 1;
        int Health = 3;
        int[,] WallPosition = new int[100,100];//здесь нужно иметь 2-мерный массив интов, содержащий информацию о стенах в лабиринте, 
                                                //0-нет, 1-есть
                                                //предлагаю инициализировать в начале каждого уровня в зависимости от типа карты
        int PositionX;
        int PositionY;
        int NextStep=0;//0-никуда, 1-следющий шаг влево, 2-вверх, 3-вправо, 4-вниз
        void CheckingWall(int NextStep) //данный метод описывает взаимодействие робота и стен через переменную NextStep, 
                                        //указывающую направление следующего шага, и массив WallPosition, 
                                        //который соотнесен с текстуркой карты и показывает наличие/отсуствие стены
        {
            switch(NextStep)
                {
                case 1 :
                        if (WallPosition[PositionX - 1, PositionY] == 1)
                        {
                            NextStep = 0;
                            Health--;
                            //Здесь нужно высветить, что уменьшилось хп и ты врезался в стену
                        }
                    break;
                case 2 :
                    if (WallPosition[PositionX, PositionY + 1] == 1)
                    {
                        NextStep = 0;
                        Health--;
                        //Здесь нужно высветить, что уменьшилось хп и ты врезался в стену
                    }
                    break;
                case 3:
                    if (WallPosition[PositionX + 1, PositionY] == 1)
                    {
                        NextStep = 0;
                        Health--;
                        //Здесь нужно высветить, что уменьшилось хп и ты врезался в стену
                    }
                    break;
                case 4:
                    if (WallPosition[PositionX, PositionY - 1] == 1)
                    {
                        NextStep = 0;
                        Health--;
                        //Здесь нужно высветить, что уменьшилось хп и ты врезался в стену
                    }
                    break;
                default:
                    break;
                }
        }
    }
}
