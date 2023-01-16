using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace underware.Edifact
{
    public class SpecificationManager
    {

        private Dictionary<string, XDocument> _specifications;

        public SpecificationManager()
        {
            _specifications = new Dictionary<string, XDocument>();
        }

        public XDocument GetSpecification(string standard, string name)
        {
            string assemblyName = string.Format("underware.Edifact.{0}", standard);
            var assembly = Assembly.Load(assemblyName);

            string entryName = string.Format("{0}{1}.xml", standard, name);

            if (!_specifications.ContainsKey(entryName))
            {
                string resourcePath = string.Format("{0}.Messages.Structures.{1}.xml", assemblyName, name);

                using (Stream stream = assembly.GetManifestResourceStream(resourcePath))
                {
                    if (stream == null)
                        throw new NullReferenceException(string.Format("Specification {0} was not found in resouces!", resourcePath));

                    XDocument xdoc = XDocument.Load(stream);
                    _specifications.Add(entryName, xdoc);
                }
            }

            return _specifications[entryName];
        }

        private static Lazy<SpecificationManager> instance = new Lazy<SpecificationManager>(() => new SpecificationManager());

        public static SpecificationManager Instance => instance.Value;
    }

}
