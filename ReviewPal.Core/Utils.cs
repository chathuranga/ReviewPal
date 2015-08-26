using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ReviewPal.Core
{
    public class Utils
    {
        #region Public properties

        public static string AssemblyTitle { get; set; }

        public static string AssemblyPath { get; set; }

        #endregion

        #region Public methods

        public static void HandleException(Exception ex)
        {
            MessageBox.Show(ex.Message /* + ex.Source*/ , AssemblyTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Initializes this instance, mainly the static properties.
        /// </summary>
        public static void Initialize()
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            AssemblyPath = GetAssemblyPath(asm);
            AssemblyTitle = GetAssemblyTitle(asm);
        }

        /// <summary>
        /// Gets the serialized XML.
        /// </summary>
        /// <returns></returns>
        public static string GetSerializedXml<T>(T objectToSerialize)
        {
            using (var stringWriter = new StringWriter())
            {
                var settings = new XmlWriterSettings
                {
                    Encoding = Encoding.UTF8,
                    OmitXmlDeclaration = true
                };
                using (var writer = XmlWriter.Create(stringWriter, settings))
                {
                    var xmlSerializer = new XmlSerializer(typeof(T));
                    xmlSerializer.Serialize(writer, objectToSerialize);
                }
                return stringWriter.ToString();
            }
        }

        /// <summary>
        /// Loads an object from an XML string.
        /// </summary>
        /// <param name="Xml">The XML.</param>
        /// <returns></returns>
        public static T LoadFromXml<T>(string Xml)
        {
            XmlSerializer ser;
            ser = new XmlSerializer(typeof(T));
            StringReader stringReader;
            stringReader = new StringReader(Xml);
            XmlTextReader xmlReader;
            xmlReader = new XmlTextReader(stringReader);
            object obj;
            obj = ser.Deserialize(xmlReader);
            xmlReader.Close();
            stringReader.Close();
            return (T)obj;
        }

        #endregion

        #region Private helper method

        /// <summary>
        /// Gets the assembly title.
        /// </summary>
        /// <param name="asm">The asm.</param>
        /// <returns></returns>
        private static string GetAssemblyTitle(Assembly asm)
        {
            object[] attributes = asm.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0)
            {
                AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "")
                {
                    return titleAttribute.Title;
                }
            }
            return "ReviewPal";
        }

        /// <summary>
        /// Gets the assembly path.
        /// </summary>
        /// <param name="asm">The asm.</param>
        /// <returns></returns>
        private static string GetAssemblyPath(Assembly asm)
        {
            return Path.GetDirectoryName(asm.CodeBase);
        }

        #endregion
    }
}