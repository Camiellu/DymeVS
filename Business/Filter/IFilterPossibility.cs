﻿using Business.Models;

namespace Business.Filter
{
    public interface IFilterPossibility
    {
        bool Filter(Dish dish);
    }
}