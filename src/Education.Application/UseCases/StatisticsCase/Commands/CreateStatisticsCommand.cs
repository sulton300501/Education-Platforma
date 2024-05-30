﻿using Education.Domain.Entities.DemoModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.UseCases.StatisticsCase.Commands
{
    public class CreateStatisticsCommand : IRequest<ResponseModel>
    {
        public int ActiveStudents { get; set; }
        public int ActiveMembers { get; set; }
        public int Countries { get; set; }
    }
}
