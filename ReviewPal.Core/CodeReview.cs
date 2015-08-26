using System;
using System.Collections.Generic;
using System.Xml;

namespace ReviewPal.Core
{
    [Serializable]
    public class CodeReview
    {
        
        private const string ReviewPalDataXpath = "//Data[@id='ReviewPalData']";

        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string WorkProductName { get; set; }
        public string WorkProductVersion { get; set; }
        public string WorkProductSize { get; set; }
        public string WorkProductReleaseDateForReview{ get; set;}
        public string ReviewedBy { get; set; }
        public string ReviewedDate{ get; set;}
        public string ReviewStatus { get; set; }
        public string ReviewActionTakenBy { get; set; }
        public string ReviewActionTakenDate { get; set; }
        public string ReviewPreparationEffort { get; set; }
        public string ReviewEffort { get; set; }
        public string ReworkEffrot { get; set; }
        public string ReviewEfficiency { get; set; }
        public List<Review> Reviews;

        public static XmlNode GetDataNode(XmlDocument reviewDocument)
        {
            XmlNode dataNode = reviewDocument.SelectSingleNode(ReviewPalDataXpath);
            return dataNode;
        }
    }
}