﻿using DataBase.Repositories.Interfaces;
using Shared.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Repositories;

public class QuizQuestionRepository : GenericRepository<QuizQuestion>, IQuizQuestionRepository
{
    public QuizQuestionRepository(AppDbContext context) : base(context)
    {
    }
}

