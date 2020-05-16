//JAH 2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Define
{
    public partial class frmDefine : Form
    {
        public frmDefine()
        {
            InitializeComponent();
        }

        private void btnDefineWord_Click(object sender, EventArgs e)
        {
            List<Result> results;
            results = searchDefinition(txtWordToDefine.Text);

            if(results != null)
            {
                updateFields(results);
            }
         
        }

        private List<Result> searchDefinition(string wordToDefine)
        {
            try
            {
                if (wordToDefine != "")
                {
                    string dictionaryURL = "https://api.dictionaryapi.dev/api/v2/entries/en/";
                    var request = WebRequest.Create(dictionaryURL + wordToDefine);
                    Console.WriteLine(request.RequestUri);
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                    Stream dataStream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(dataStream);
                    string responseString = reader.ReadToEnd();

                    var results = JsonConvert.DeserializeObject<List<Result>>(responseString);

                    return results;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        private void updateFields(List<Result> results)
        {
            try
            {
                if (results != null)
                {
                    foreach(var result in results)
                    {
                        if (result != null)
                        {
                            tvResult.Nodes.Clear();
                            var wordNode = tvResult.Nodes.Add(result.Word);
                            wordNode.Nodes.Add("Origin: " + result.Origin);
                            wordNode.Nodes.Add("Phonetic: " + result.Phonetic);

                            var meaningsNode = tvResult.Nodes.Add("Meanings");

                            foreach (var meaning in result.Meanings)
                            {
                                if (meaning != null)
                                {
                                    var partOfSpeechNode = meaningsNode.Nodes.Add(meaning.PartOfSpeech);

                                    foreach (var definition in meaning.Definitions)
                                    {
                                        if (definition != null)
                                        {
                                            var definitionsNode = partOfSpeechNode.Nodes.Add("Definition: " + definition.DefinitionDefinition);

                                            if (definition.Example != null)
                                            {
                                                definitionsNode.Nodes.Add("Example: " + definition.Example);
                                            }

                                            if (definition.Synonyms != null)
                                            {
                                                var synonymsNode = definitionsNode.Nodes.Add("Synonyms");

                                                foreach (var synonym in definition.Synonyms)
                                                {
                                                    if (synonym != null)
                                                    {
                                                        synonymsNode.Nodes.Add(synonym);
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }      
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
