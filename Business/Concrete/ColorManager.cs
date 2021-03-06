﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        IRulesService<IEntity> _rules;


        public ColorManager(IColorDal colorDal, IRulesService<IEntity> rules)
        {
            _colorDal = colorDal;
            _rules = rules;
        }
        public void Add(Color entity)
        {
            _colorDal.Add(entity);
        }

        public void Delete(Color entity)
        {
            _colorDal.Delete(entity);
        }

        public Color Get(int id)
        {
            return _colorDal.Get(p => p.Id == id);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public void Update(Color entity)
        {
            _colorDal.Update(entity);
        }
    }
}
