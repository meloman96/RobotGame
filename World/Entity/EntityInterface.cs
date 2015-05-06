using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject.World.Entity
{
    interface EntityInterface
    {
        // Рисование объекта.
        void draw();
        // Обновление положения(координат)/характеристик.
        void update();
        // Начальная координата и получение координат.
        void setCoordinates();
        // Проверяем на столкновение двух объектов.
        void collide();
    }
}
