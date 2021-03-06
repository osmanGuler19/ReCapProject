﻿using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RulesManager : IRulesService<IEntity>
    {
        public void MinNameRule(IEntity entity)
        {
            var downCastedEntity = (Car)entity;

            if(downCastedEntity.Description.Length < 2)
            {
                throw new Exception("Araba ismi minimum iki karakter içermelidir");
            }
        }

        public void MinPriceRule(IEntity entity)
        {
            var downCastedEntity = (Car)entity;

            if(downCastedEntity.DailyPrice <= 0)
            {
                throw new Exception("Bir aracın günlük fiyatı sıfırdan büyük olmalıdır");
            }

            
        }
    }
}
