﻿using Capstone.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Web.DAL
{
    public interface ISurveyDal
    {
        void CreateSurvey(Survey survey);
        //List<Survey> GetSurveys();
    }
}
