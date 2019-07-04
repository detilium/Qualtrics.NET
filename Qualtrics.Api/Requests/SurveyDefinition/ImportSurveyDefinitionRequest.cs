﻿using Qualtrics.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Requests
{
    public class ImportSurveyDefinitionRequest
    {
        public SurveyMetadata SurveyEntry { get; set; }
        public List<SurveyElement> SurveyElements { get; set; }
    }
}
