using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualtrics.Api.Models
{
    public class Options
    {
        public bool BackButton { get; set; }
        public bool SaveAndContinue { get; set; }
        public string SurveyProtection { get; set; }
        public bool BallotBoxStuffingPrevention { get; set; }
        public string NoIndex { get; set; }
        public bool SecureResponseFiles { get; set; }
        public string SurveyExpiration { get; set; }
        public string SurveyTermination { get; set; }
        public string Header { get; set; }
        public string Footer { get; set; }
        public string ProgressBarDisplay { get; set; }
        public string PartialData { get; set; }
        public string ValidationMessage { get; set; }
        public string PreviousButton { get; set; }
        public string NextButton { get; set; }
        public string SkinLibrary { get; set; }
        public string SkinType { get; set; }
        public string Skin { get; set; }
        public int NewScoring { get; set; }
        public Dictionary<string, object[]> AvilableLanguages { get; set; }
        public int SkinQuestionWidth { get; set; }
        public string SurveyLanguage { get; set; }
        public string ActiveResponseSet { get; set; }
        public DateTime? SurveyStartDate { get; set; }
        public DateTime? SurveyExpirationDate { get; set; }
        public DateTime SurveyCreationDate { get; set; }
    }
}
