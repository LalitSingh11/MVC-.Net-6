using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHI.SalesArchitect.WebAdmin.Models
{
    public sealed class CSVResult<T> : System.Web.Mvc.FileResult
    {
        private IEnumerable<T> collection;
        private String[] columnsToExclude;
        private string seperator;
        public CSVResult(IEnumerable<T> collection, string seperator, params String[] columnsToExclude)
            : base("text/csv")
        {
            this.collection = collection;
            this.columnsToExclude = columnsToExclude;
            this.seperator = seperator;
        }

        protected override void WriteFile(HttpResponseBase response)
        {
            System.IO.Stream outputStream = response.OutputStream;
            using (MemoryStream mstream = new MemoryStream())
            {
                WriteObject(mstream);
                outputStream.Write(mstream.GetBuffer(), 0, (int)mstream.Length);
            }
        }

        private void WriteObject(Stream stream)
        {
            // We will follow the recommandations stated in this article
            // http://www.commentcamarche.net/faq/sujet-7273-exporter-a-coup-sur-du-csv
            // - embedding all values in quotes
            // - double quote literal values
            // - add \n\r between each lines.

            StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.Default);

            // Render columns
            Type modelType = typeof(T);
            List<ModelMetadata> metadatas = ModelMetadataProviders.Current.GetMetadataForProperties(null, modelType).ToList();

            for (int i = 0; i < metadatas.Count; )
            {
                if (Array.IndexOf<String>(columnsToExclude, metadatas[i].PropertyName) != -1)
                    metadatas.RemoveAt(i);
                else
                {
                    WriteValue(writer, metadatas[i].DisplayName ?? metadatas[i].PropertyName, this.seperator);
                    i++;
                }
            }

            writer.WriteLine();
            // Render data
            var en = collection.GetEnumerator();
            while (en.MoveNext())
            {
                ModelMetadata mprop = ModelMetadataProviders.Current.GetMetadataForType(() => en.Current, modelType);

                foreach (ModelMetadata prop in mprop.Properties)
                {
                    WriteValue(writer, prop.SimpleDisplayText ?? String.Empty, this.seperator);
                }
                writer.WriteLine();
            }

            writer.Flush();
        }

        private static void WriteValue(StreamWriter writer, String literal, string seperator)
        {
            // Enclose values in quote
            writer.Write("\"");
            string line = literal.Replace("\"", "\"\"");
            writer.Write(line);
            writer.Write(string.Format("\"{0}", seperator));
        }
    }
}
