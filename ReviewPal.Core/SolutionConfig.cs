using System.IO;
using System.Xml;

namespace ReviewPal.Core
{
    public partial class SolutionConfig
    {
        public static SolutionConfig  GetSolutionConfig()
        {
            SolutionConfig solutionConfig = null;
            var path = GetConfigPath();
            if(File.Exists(path))
            {
                solutionConfig = Utils.LoadFromXml<SolutionConfig>(File.ReadAllText(path));
            }
            
            return solutionConfig;
        }
        public void Save()
        {
            var path = GetConfigPath();
            XmlDocument solutionConfig = new XmlDocument();
            solutionConfig.LoadXml(Utils.GetSerializedXml(this));
            solutionConfig.Save(path);
        }

        public void Delete()
        {
            var path = GetConfigPath();
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        private static string GetConfigPath()
        {
            return Path.GetDirectoryName(VSIDEHelper.VisualStudioInstance.Solution.FullName) +
                          "\\.ReviewPal.xml";
        }
    }
    
    // pasted XML as Type

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class SolutionConfig
    {

        private object reviewPalFileLocationField;

        /// <remarks/>
        public object ReviewPalFileLocation
        {
            get
            {
                return this.reviewPalFileLocationField;
            }
            set
            {
                this.reviewPalFileLocationField = value;
            }
        }
    }
}
