﻿using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Responses
{
    public class GetSurveyResponse : BaseResponse
    {
        public Survey Result { get; set; }
    }
}
