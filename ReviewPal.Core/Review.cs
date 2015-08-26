using System;

namespace ReviewPal.Core
{
    [Serializable]
    public class Review
    {
        public int ReviewId{ get; set;}
        public int Line { get; set; }
        public string File { get; set; }
        public string Project { get; set; }

        public string Status{ get; set;}
        public string Comment{ get; set;}
        public string Description { get; set; }
        public string Severity { get; set; }
        public string DefectType { get; set; }
        public string InjectedPhase { get; set; }
        public string RevieweeComment { get; set; }
        public string ReExamined { get; set; }
        public string ReviewerComment { get; set; }

        public static string ColumnReviewId = "ID";
        public static string ColumnLine = "Line";
        public static string ColumnFile = "File";
        public static string ColumnProject = "Project";
        public static string ColumnStatus = "Status";
        public static string ColumnComment = "Comment";
        public static string ColumnDescription = "Description";
        public static string ColumnSeverity = "Severity";
        public static string ColumnDefectType = "DefectType";
    }
}